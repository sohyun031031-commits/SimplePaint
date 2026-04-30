using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace SimplePaint
{
    public partial class Form1 : Form
    {
        enum ToolType { Line, Rectangle, Circle }  // 사용할 도형 타입
        private Bitmap canvasBitmap;          // 실제 그림이 저장되는 비트맵
        private Graphics canvasGraphics;      // 비트맵 위에 그리기 위한 객체
        private bool isDrawing = false;       // 현재 드래그 중인지 여부
        private Point startPoint;             // 드래그 시작점
        private Point endPoint;               // 드래그 끝점
        private ToolType currentTool = ToolType.Line;  // 현재 선택된 도형
        private Color currentColor = Color.Black;      // 현재 색상
        private int currentLineWidth = 2;              // 현재 선 두께
        private float zoomLevel = 1.0f;                // 확대/축소 레벨
        private string currentFilePath = "";           // 현재 열려있는 파일 경로

        public Form1()
        {
            InitializeComponent();

            // 캔버스초기화
            canvasBitmap = new Bitmap(picCanvas.Width, picCanvas.Height);
            canvasGraphics = Graphics.FromImage(canvasBitmap);
            canvasGraphics.Clear(Color.White);   // 캔버스를흰색으로초기화

            picCanvas.Image = canvasBitmap;   // 그린그림을화면(PictureBox)에표시

            // 마우스이벤트연결
            picCanvas.MouseDown += picCanvas_MouseDown;
            picCanvas.MouseMove += picCanvas_MouseMove;
            picCanvas.MouseUp += picCanvas_MouseUp;

            // picCanvas가다시그려질때PicCanvas_Paint함수를실행하도록연결
            picCanvas.Paint += PicCanvas_Paint;// 도형선택버튼이벤트연결
            btnLine.Click += btnLine_Click
                ; btnRectangle.Click += btnRectangle_Click;
            btnCircle.Click += btnCircle_Click;


            // 색상콤보박스이벤트연결
            cmbColor.SelectedIndexChanged += cmbColor_SelectedIndexChanged;
            cmbColor.SelectedIndex = 0;  // 기본값: Black

            // 선두께트랙바이벤트연결
            trbLineWidth.Minimum = 1;    // 최소값
            trbLineWidth.Maximum = 10;   // 최대값
            trbLineWidth.Value = 2;
            trbLineWidth.ValueChanged += trbLineWidth_ValueChanged;

            // 저장버튼이벤트연결
            btnSaveFile.Click += btnSaveFile_Click;

            // 열기버튼이벤트연결
            btnOpenFile.Click += btnOpenFile_Click;

            // 마우스휠이벤트연결(확대/축소)
            picCanvas.MouseWheel += picCanvas_MouseWheel;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void picCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;             // 드래그시작
            startPoint = e.Location;      // 시작점저장
        }

        private void picCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isDrawing) return;       // 그림그리기와상관없는마우스움직임은무시

            endPoint = e.Location;        // 현재위치갱신

            // picCanvas를다시그려라(Paint 이벤트를발생시킨다)
            picCanvas.Invalidate();       // 화면다시그리기(미리보기)
        }

        private void picCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (!isDrawing) return;     // 그림그리기와상관없는마우스움직임은무시
            isDrawing = false;          // 드래그종료
            endPoint = e.Location;

            // 실제비트맵에도형그리기(확정)
            using (Pen pen = new Pen(currentColor, currentLineWidth))
            {
                DrawShape(canvasGraphics, pen, startPoint, endPoint);
            }

            picCanvas.Invalidate();     // 다시그려서결과반영, Paint 이벤트발생
        }

        private void PicCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (!isDrawing) return;
            
            // 점선펜(미리보기용)
            using (Pen previewPen= new Pen(currentColor, currentLineWidth))
            {
                previewPen.DashStyle= DashStyle.Dash;
                DrawShape(e.Graphics, previewPen, startPoint, endPoint);
            }
        }

        private void DrawShape(Graphics g, Pen pen, Point p1, Point p2) 
        {
            Rectangle rect = GetRectangle(p1, p2);
            switch (currentTool) 
            {
                case ToolType.Line: 
                    g.DrawLine(pen, p1, p2);
                    break;
                case ToolType.Rectangle:
                    g.DrawRectangle(pen, rect); 
                    break; 
                case ToolType.Circle:
                    g.DrawEllipse(pen, rect); 
                    break; 
            }
        }

        private Rectangle GetRectangle(Point p1, Point p2) 
        {
            return new Rectangle(
                Math.Min(p1.X, p2.X),
                Math.Min(p1.Y, p2.Y), 
                Math.Abs(p1.X - p2.X), 
                Math.Abs(p1.Y - p2.Y)); 
        }

        private void btnLine_Click(object sender, EventArgs e) 
        {
            currentTool = ToolType.Line; 
        }
        private void btnRectangle_Click(object sender, EventArgs e) 
        { 
            currentTool = ToolType.Rectangle;
        }
        private void btnCircle_Click(object sender, EventArgs e)
        {
            currentTool = ToolType.Circle; 
        }

        private void cmbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbColor.SelectedIndex)
            {
                case 0: // Black 검정
                currentColor= Color.Black;
                    break;
                case 1: // Red 빨강
                    currentColor = Color.Red;
                        break;
                case 2: // Blue 파랑
                    currentColor= Color.Blue;
                    break;
                case 3: // Green 녹색
                    currentColor= Color.Green;
                    break;
                default:
                    currentColor= Color.Black;
                    break;
            }
        }
        private void trbLineWidth_ValueChanged(object sender, EventArgs e)
        { 
            currentLineWidth = trbLineWidth.Value; 
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            // SaveFileDialog 생성
            SaveFileDialog saveDialog = new SaveFileDialog();

            // 파일 필터 설정 (3가지 형식)
            saveDialog.Filter = "PNG 이미지 (*.png)|*.png|JPG 이미지 (*.jpg)|*.jpg|BMP 이미지 (*.bmp)|*.bmp|모든 파일 (*.*)|*.*";

            // 기본 파일명 설정
            saveDialog.FileName = "drawing";

            // 대화상자 표시
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // 파일 확장자 가져오기
                    string filePath = saveDialog.FileName;
                    string fileExtension = System.IO.Path.GetExtension(filePath).ToLower();

                    // 확장자에 따라 형식 결정
                    ImageFormat format;
                    switch (fileExtension)
                    {
                        case ".png":
                            format = ImageFormat.Png;
                            break;
                        case ".jpg":
                        case ".jpeg":
                            format = ImageFormat.Jpeg;
                            break;
                        case ".bmp":
                            format = ImageFormat.Bmp;
                            break;
                        default:
                            MessageBox.Show("지원하지 않는 형식입니다.\n(.png, .jpg, .bmp만 지원합니다)", "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                    }

                    // 이미지 저장
                    canvasBitmap.Save(filePath, format);
                    MessageBox.Show($"파일이 저장되었습니다.\n경로: {filePath}", "저장 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"파일 저장 중 오류가 발생했습니다.\n{ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            // OpenFileDialog 생성
            OpenFileDialog openDialog = new OpenFileDialog();

            // 파일 필터 설정
            openDialog.Filter = "이미지 파일 (*.png, *.jpg, *.bmp)|*.png;*.jpg;*.jpeg;*.bmp|PNG 이미지 (*.png)|*.png|JPG 이미지 (*.jpg)|*.jpg|BMP 이미지 (*.bmp)|*.bmp|모든 파일 (*.*)|*.*";
            openDialog.Title = "이미지 파일 열기";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // 기존 비트맵과 그래픽 객체 해제
                    canvasGraphics?.Dispose();
                    canvasBitmap?.Dispose();

                    // 새 이미지 로드
                    Bitmap loadedImage = new Bitmap(openDialog.FileName);
                    currentFilePath = openDialog.FileName;

                    // 캔버스 크기를 로드한 이미지 크기로 설정
                    canvasBitmap = new Bitmap(loadedImage.Width, loadedImage.Height);
                    canvasGraphics = Graphics.FromImage(canvasBitmap);

                    // 로드한 이미지를 캔버스에 그리기
                    canvasGraphics.DrawImage(loadedImage, 0, 0);
                    loadedImage.Dispose();

                    // PictureBox 크기 조정
                    picCanvas.Width = canvasBitmap.Width;
                    picCanvas.Height = canvasBitmap.Height;
                    picCanvas.Image = canvasBitmap;

                    // 줌 레벨 리셋
                    zoomLevel = 1.0f;

                    // 폼 크기 조정 (필요시)
                    if (canvasBitmap.Width > 700 || canvasBitmap.Height > 400)
                    {
                        this.Width = Math.Min(canvasBitmap.Width + 50, 1200);
                        this.Height = Math.Min(canvasBitmap.Height + 250, 800);
                    }

                    MessageBox.Show($"이미지가 로드되었습니다.\n크기: {canvasBitmap.Width}x{canvasBitmap.Height}px", "로드 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"파일을 열 수 없습니다.\n{ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void picCanvas_MouseWheel(object sender, MouseEventArgs e)
        {
            // 마우스휠 스크롤로 확대/축소 (Ctrl 키 필요)
            if (ModifierKeys == Keys.Control)
            {
                if (e.Delta > 0)
                {
                    // 확대 (마우스휠 위로)
                    ZoomImage(1.1f);
                }
                else
                {
                    // 축소 (마우스휠 아래로)
                    ZoomImage(0.9f);
                }

                // MouseWheel 이벤트 처리됨 표시
                ((HandledMouseEventArgs)e).Handled = true;
            }
        }

        private void ZoomImage(float factor)
        {
            // 줌 레벨 업데이트 (최소 0.5배, 최대 5배)
            float newZoom = zoomLevel * factor;
            if (newZoom >= 0.5f && newZoom <= 5.0f)
            {
                zoomLevel = newZoom;

                // PictureBox 크기 조정
                int newWidth = (int)(canvasBitmap.Width * zoomLevel);
                int newHeight = (int)(canvasBitmap.Height * zoomLevel);

                picCanvas.Width = newWidth;
                picCanvas.Height = newHeight;

                // PictureBox 다시 그리기
                picCanvas.Invalidate();
            }
        }

        private void ApplyZoom(Graphics g, int x, int y, int width, int height)
        {
            // 확대/축소 적용하여 그리기
            if (zoomLevel != 1.0f)
            {
                g.TranslateTransform(x, y);
                g.ScaleTransform(zoomLevel, zoomLevel);
                g.TranslateTransform(-x, -y);
            }
        }
    }
}
