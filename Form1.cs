using System;
using System.Drawing;
using System.Drawing.Imaging;
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
        // private int currentLineWidth = 2;              // 현재 선 두께

        public Form1()
        {
            InitializeComponent();

            // 캔버스초기화
            canvasBitmap= new Bitmap(picCanvas.Width, picCanvas.Height);
            canvasGraphics= Graphics.FromImage(canvasBitmap);
            canvasGraphics.Clear(Color.White);   // 캔버스를흰색으로초기화

            picCanvas.Image= canvasBitmap;   // 그린그림을화면(PictureBox)에표시

            // 마우스이벤트연결
            picCanvas.MouseDown+= PicCanvas_MouseDown;
            picCanvas.MouseMove+= PicCanvas_MouseMove;
            picCanvas.MouseUp+= PicCanvas_MouseUp;
            
            // picCanvas가다시그려질때PicCanvas_Paint함수를실행하도록연결
            picCanvas.Paint+= PicCanvas_Paint;// 도형선택버튼이벤트연결
            btnLine.Click+= btnLine_Click
                ;btnRectangle.Click+= btnRectangle_Click;
            btnCircle.Click+= btnCircle_Click;


            // 색상콤보박스이벤트연결
            cmbColor.SelectedIndexChanged+= cmbColor_SelectedIndexChanged;
            cmbColor.SelectedIndex= 0;  // 기본값: Black
            
            // 선두께트랙바이벤트연결
            trbLineWidth.Minimum= 1;    // 최소값
            trbLineWidth.Maximum= 10;   // 최대값
            trbLineWidth.Value= 2;
            trbLineWidth.ValueChanged+= trbLineWidth_ValueChanged;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
