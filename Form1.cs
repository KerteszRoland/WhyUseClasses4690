using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{

    public partial class Form1 : Form
    {
        //265 itt tartottam
        // set sqrs colors

        Color a1 = Color.White, a3 = Color.White, a5 = Color.White, a7 = Color.White, b2 = Color.White, b4 = Color.White, b6 = Color.White, b8 = Color.White, c1 = Color.White, c3 = Color.White, c5 = Color.White, c7 = Color.White, d2 = Color.White, d4 = Color.White, d6 = Color.White, d8 = Color.White, e1 = Color.White, e3 = Color.White, e5 = Color.White, e7 = Color.White, f2 = Color.White, f4 = Color.White, f6 = Color.White, f8 = Color.White, g1 = Color.White, g3 = Color.White, g5 = Color.White, g7 = Color.White, h2 = Color.White, h4 = Color.White, h6 = Color.White, h8 = Color.White;

        Color a2 = Color.Gray, a4 = Color.Gray, a6 = Color.Gray, a8 = Color.Gray, b1 = Color.Gray, b3 = Color.Gray, b5 = Color.Gray, b7 = Color.Gray, c2 = Color.Gray, c4 = Color.Gray, c6 = Color.Gray, c8 = Color.Gray, d1 = Color.Gray, d3 = Color.Gray, d5 = Color.Gray, d7 = Color.Gray, e2 = Color.Gray, e4 = Color.Gray, e6 = Color.Gray, e8 = Color.Gray, f1 = Color.Gray, f3 = Color.Gray, f5 = Color.Gray, f7 = Color.Gray, g2 = Color.Gray, g4 = Color.Gray, g6 = Color.Gray, g8 = Color.Gray, h1 = Color.Gray, h3 = Color.Gray, h5 = Color.Gray, h7 = Color.Gray;

        //string path = "D:/project/asd/Chess/";

        public Form1()
        {
            InitializeComponent();
        }

        //Square cordinates
        Point a1c = new Point(10, 10);
        Point a2c = new Point(60, 10);
        Point a3c = new Point(110, 10);
        Point a4c = new Point(160, 10);
        Point a5c = new Point(210, 10);
        Point a6c = new Point(260, 10);
        Point a7c = new Point(310, 10);
        Point a8c = new Point(360, 10);
        Point b1c = new Point(10, 60);
        Point b2c = new Point(60, 60);
        Point b3c = new Point(110, 60);
        Point b4c = new Point(160, 60);
        Point b5c = new Point(210, 60);
        Point b6c = new Point(260, 60);
        Point b7c = new Point(310, 60);
        Point b8c = new Point(360, 60);
        Point c1c = new Point(10, 110);
        Point c2c = new Point(60, 110);
        Point c3c = new Point(110, 110);
        Point c4c = new Point(160, 110);
        Point c5c = new Point(210, 110);
        Point c6c = new Point(260, 110);
        Point c7c = new Point(310, 110);
        Point c8c = new Point(360, 110);
        Point d1c = new Point(10, 160);
        Point d2c = new Point(60, 160);
        Point d3c = new Point(110, 160);
        Point d4c = new Point(160, 160);
        Point d5c = new Point(210, 160);
        Point d6c = new Point(260, 160);
        Point d7c = new Point(310, 160);
        Point d8c = new Point(360, 160);
        Point e1c = new Point(10, 210);
        Point e2c = new Point(60, 210);
        Point e3c = new Point(110, 210);
        Point e4c = new Point(160, 210);
        Point e5c = new Point(210, 210);
        Point e6c = new Point(260, 210);
        Point e7c = new Point(310, 210);
        Point e8c = new Point(360, 210);
        Point f1c = new Point(10, 260);
        Point f2c = new Point(60, 260);
        Point f3c = new Point(110, 260);
        Point f4c = new Point(160, 260);
        Point f5c = new Point(210, 260);
        Point f6c = new Point(260, 260);
        Point f7c = new Point(310, 260);
        Point f8c = new Point(360, 260);
        Point g1c = new Point(10, 310);
        Point g2c = new Point(60, 310);
        Point g3c = new Point(110, 310);
        Point g4c = new Point(160, 310);
        Point g5c = new Point(210, 310);
        Point g6c = new Point(260, 310);
        Point g7c = new Point(310, 310);
        Point g8c = new Point(360, 310);
        Point h1c = new Point(10, 360);
        Point h2c = new Point(60, 360);
        Point h3c = new Point(110, 360);
        Point h4c = new Point(160, 360);
        Point h5c = new Point(210, 360);
        Point h6c = new Point(260, 360);
        Point h7c = new Point(310, 360);
        Point h8c = new Point(360, 360);
        //Square cordinates

        //Black piece cordinates
        Point BlackPawn1_xy = new Point(10, 60);
        Point BlackPawn2_xy = new Point(60, 60);
        Point BlackPawn3_xy = new Point(110, 60);
        Point BlackPawn4_xy = new Point(160, 60);
        Point BlackPawn5_xy = new Point(210, 60);
        Point BlackPawn6_xy = new Point(260, 60);
        Point BlackPawn7_xy = new Point(310, 60);
        Point BlackPawn8_xy = new Point(360, 60);
        Point BlackRook1_xy = new Point(10, 10);
        Point BlackKnight1_xy = new Point(60, 10);
        Point BlackBishop1_xy = new Point(110, 10);
        Point BlackQueen_xy = new Point(160, 10);
        Point BlackKing_xy = new Point(210, 10);
        Point BlackBishop2_xy = new Point(260, 10);
        Point BlackKnight2_xy = new Point(310, 10);
        Point BlackRook2_xy = new Point(360, 10);
        //Black piece cordinates

        //White piece cordinates
        Point WhitePawn1_xy = new Point(10, 310);
        Point WhitePawn2_xy = new Point(60, 310);
        Point WhitePawn3_xy = new Point(110, 310);
        Point WhitePawn4_xy = new Point(160, 310);
        Point WhitePawn5_xy = new Point(210, 310);
        Point WhitePawn6_xy = new Point(260, 310);
        Point WhitePawn7_xy = new Point(310, 310);
        Point WhitePawn8_xy = new Point(360, 310);
        Point WhiteRook1_xy = new Point(10, 360);
        Point WhiteKnight1_xy = new Point(60, 360);
        Point WhiteBishop1_xy = new Point(110, 360);
        Point WhiteQueen_xy = new Point(160, 360);
        Point WhiteKing_xy = new Point(210, 360);
        Point WhiteBishop2_xy = new Point(260, 360);
        Point WhiteKnight2_xy = new Point(310, 360);
        Point WhiteRook2_xy = new Point(360, 360);
        //White piece cordinates

        //Black piece selected
        bool BlackPawn1_selected = false;
        bool BlackPawn2_selected = false;
        bool BlackPawn3_selected = false;
        bool BlackPawn4_selected = false;
        bool BlackPawn5_selected = false;
        bool BlackPawn6_selected = false;
        bool BlackPawn7_selected = false;
        bool BlackPawn8_selected = false;
        bool BlackRook1_selected = false;
        bool BlackKnight1_selected = false;
        bool BlackBishop1_selected = false;
        bool BlackQueen_selected = false;
        bool BlackKing_selected = false;
        bool BlackBishop2_selected = false;
        bool BlackKnight2_selected = false;
        bool BlackRook2_selected = false;
        //Black piece selected

        //White piece selected
        bool WhitePawn1_selected = false;
        bool WhitePawn2_selected = false;
        bool WhitePawn3_selected = false;
        bool WhitePawn4_selected = false;
        bool WhitePawn5_selected = false;
        bool WhitePawn6_selected = false;
        bool WhitePawn7_selected = false;
        bool WhitePawn8_selected = false;
        bool WhiteRook1_selected = false;
        bool WhiteKnight1_selected = false;
        bool WhiteBishop1_selected = false;
        bool WhiteQueen_selected = false;
        bool WhiteKing_selected = false;
        bool WhiteBishop2_selected = false;
        bool WhiteKnight2_selected = false;
        bool WhiteRook2_selected = false;
        //White piece selected

        //Black piece toggle
        bool BlackPawn1_toggle = false;
        bool BlackPawn2_toggle = false;
        bool BlackPawn3_toggle = false;
        bool BlackPawn4_toggle = false;
        bool BlackPawn5_toggle = false;
        bool BlackPawn6_toggle = false;
        bool BlackPawn7_toggle = false;
        bool BlackPawn8_toggle = false;
        bool BlackRook1_toggle = false;
        bool BlackKnight1_toggle = false;
        bool BlackBishop1_toggle = false;
        bool BlackQueen_toggle = false;
        bool BlackKing_toggle = false;
        bool BlackBishop2_toggle = false;
        bool BlackKnight2_toggle = false;
        bool BlackRook2_toggle = false;
        //Black piece toggle

        //White piece toggle
        bool WhitePawn1_toggle = false;
        bool WhitePawn2_toggle = false;
        bool WhitePawn3_toggle = false;
        bool WhitePawn4_toggle = false;
        bool WhitePawn5_toggle = false;
        bool WhitePawn6_toggle = false;
        bool WhitePawn7_toggle = false;
        bool WhitePawn8_toggle = false;
        bool WhiteRook1_toggle = false;
        bool WhiteKnight1_toggle = false;
        bool WhiteBishop1_toggle = false;
        bool WhiteQueen_toggle = false;
        bool WhiteKing_toggle = false;
        bool WhiteBishop2_toggle = false;
        bool WhiteKnight2_toggle = false;
        bool WhiteRook2_toggle = false;
        //White piece toggle

        Point useless2 = new Point(-500, -500);
        PictureBox temp;
        Point Blackcaptured = new Point(300, 550);

        bool Chess_Black = false;
        bool Chess_White = false;

        bool blackturn = false;
        bool whiteturn = true;

        //start
        private void start()
        {
            //Black piece cordinates
            BlackPawn1_xy = pictureBox_blackpawn1.Location;
            BlackPawn2_xy = pictureBox_blackpawn2.Location;
            BlackPawn3_xy = pictureBox_blackpawn3.Location;
            BlackPawn4_xy = pictureBox_blackpawn4.Location;
            BlackPawn5_xy = pictureBox_blackpawn5.Location;
            BlackPawn6_xy = pictureBox_blackpawn6.Location;
            BlackPawn7_xy = pictureBox_blackpawn7.Location;
            BlackPawn8_xy = pictureBox_blackpawn8.Location;
            BlackRook1_xy = pictureBox_blackrook1.Location;
            BlackKnight1_xy = pictureBox_blackknight1.Location;
            BlackBishop1_xy = pictureBox_blackbishop1.Location;
            BlackQueen_xy = pictureBox_blackqueen.Location;
            BlackKing_xy = pictureBox_blackking.Location;
            BlackBishop2_xy = pictureBox_blackbishop2.Location;
            BlackKnight2_xy = pictureBox_blackknight2.Location;
            BlackRook2_xy = pictureBox_blackrook2.Location;
            //Black piece cordinates

            //White piece cordinates
            WhitePawn1_xy = pictureBox_whitepawn1.Location;
            WhitePawn2_xy = pictureBox_whitepawn2.Location;
            WhitePawn3_xy = pictureBox_whitepawn3.Location;
            WhitePawn4_xy = pictureBox_whitepawn4.Location;
            WhitePawn5_xy = pictureBox_whitepawn5.Location;
            WhitePawn6_xy = pictureBox_whitepawn6.Location;
            WhitePawn7_xy = pictureBox_whitepawn7.Location;
            WhitePawn8_xy = pictureBox_whitepawn8.Location;
            WhiteRook1_xy = pictureBox_whiterook1.Location;
            WhiteKnight1_xy = pictureBox_whiteknight1.Location;
            WhiteBishop1_xy = pictureBox_whitebishop1.Location;
            WhiteQueen_xy = pictureBox_whitequeen.Location;
            WhiteKing_xy = pictureBox_whiteking.Location;
            WhiteBishop2_xy = pictureBox_whitebishop2.Location;
            WhiteKnight2_xy = pictureBox_whiteknight2.Location;
            WhiteRook2_xy = pictureBox_whiterook2.Location;
            //White piece cordinates
        }
        //start

        private PictureBox findpb(Point point)
        {
            PictureBox tmp = useless;
            
            if (point == a1c) { tmp = pictureBox_a1;}
            if (point == a2c) { tmp = pictureBox_a2; }
            if (point == a3c) { tmp = pictureBox_a3; }
            if (point == a4c) { tmp = pictureBox_a4; }
            if (point == a5c) { tmp = pictureBox_a5; }
            if (point == a6c) { tmp = pictureBox_a6; }
            if (point == a7c) { tmp = pictureBox_a7; }
            if (point == a8c) { tmp = pictureBox_a8; }

            if (point == b1c) { tmp = pictureBox_b1; }
            if (point == b2c) { tmp = pictureBox_b2; }
            if (point == b3c) { tmp = pictureBox_b3; }
            if (point == b4c) { tmp = pictureBox_b4; }
            if (point == b5c) { tmp = pictureBox_b5; }
            if (point == b6c) { tmp = pictureBox_b6; }
            if (point == b7c) { tmp = pictureBox_b7; }
            if (point == b8c) { tmp = pictureBox_b8; }

            if (point == c1c) { tmp = pictureBox_c1; }
            if (point == c2c) { tmp = pictureBox_c2; }
            if (point == c3c) { tmp = pictureBox_c3; }
            if (point == c4c) { tmp = pictureBox_c4; }
            if (point == c5c) { tmp = pictureBox_c5; }
            if (point == c6c) { tmp = pictureBox_c6; }
            if (point == c7c) { tmp = pictureBox_c7; }
            if (point == c8c) { tmp = pictureBox_c8; }

            if (point == d1c) { tmp = pictureBox_d1; }
            if (point == d2c) { tmp = pictureBox_d2; }
            if (point == d3c) { tmp = pictureBox_d3; }
            if (point == d4c) { tmp = pictureBox_d4; }
            if (point == d5c) { tmp = pictureBox_d5; }
            if (point == d6c) { tmp = pictureBox_d6; }
            if (point == d7c) { tmp = pictureBox_d7; }
            if (point == d8c) { tmp = pictureBox_d8; }

            if (point == e1c) { tmp = pictureBox_e1; }
            if (point == e2c) { tmp = pictureBox_e2; }
            if (point == e3c) { tmp = pictureBox_e3; }
            if (point == e4c) { tmp = pictureBox_e4; }
            if (point == e5c) { tmp = pictureBox_e5; }
            if (point == e6c) { tmp = pictureBox_e6; }
            if (point == e7c) { tmp = pictureBox_e7; }
            if (point == e8c) { tmp = pictureBox_e8; }

            if (point == f1c) { tmp = pictureBox_f1; }
            if (point == f2c) { tmp = pictureBox_f2; }
            if (point == f3c) { tmp = pictureBox_f3; }
            if (point == f4c) { tmp = pictureBox_f4; }
            if (point == f5c) { tmp = pictureBox_f5; }
            if (point == f6c) { tmp = pictureBox_f6; }
            if (point == f7c) { tmp = pictureBox_f7; }
            if (point == f8c) { tmp = pictureBox_f8; }

            if (point == g1c) { tmp = pictureBox_g1; }
            if (point == g2c) { tmp = pictureBox_g2; }
            if (point == g3c) { tmp = pictureBox_g3; }
            if (point == g4c) { tmp = pictureBox_g4; }
            if (point == g5c) { tmp = pictureBox_g5; }
            if (point == g6c) { tmp = pictureBox_g6; }
            if (point == g7c) { tmp = pictureBox_g7; }
            if (point == g8c) { tmp = pictureBox_g8; }

            if (point == h1c) { tmp = pictureBox_h1; }
            if (point == h2c) { tmp = pictureBox_h2; }
            if (point == h3c) { tmp = pictureBox_h3; }
            if (point == h4c) { tmp = pictureBox_h4; }
            if (point == h5c) { tmp = pictureBox_h5; }
            if (point == h6c) { tmp = pictureBox_h6; }
            if (point == h7c) { tmp = pictureBox_h7; }
            if (point == h8c) { tmp = pictureBox_h8; }

            return tmp;
        }

        bool ex1 = true;
        bool ex2 = true;
        bool ex3 = true;
        bool ex4 = true;
        bool ex5 = true;
        bool ex6 = true;

        Point p0 = new Point(0, 0);
        Point p1 = new Point(0, 0);
        Point p2 = new Point(0, 0);
        Point p3 = new Point(0, 0);
        Point p4 = new Point(0, 0);
        Point p5 = new Point(0, 0);
        Point p6 = new Point(0, 0);
        Point p7 = new Point(0, 0);
        Point p8 = new Point(0, 0);

        PictureBox pb0;
        PictureBox pb1;
        PictureBox pb2;
        PictureBox pb3;
        PictureBox pb4;
        PictureBox pb5;
        PictureBox pb6;
        PictureBox pb7;
        PictureBox pb8;

        private void kingmove(Point point, string s)
        {
            p1 = (new Point(point.X + 50, point.Y));
            p2 = (new Point(point.X - 50, point.Y));
            p3 = (new Point(point.X, point.Y + 50));
            p4 = (new Point(point.X, point.Y - 50));
            p5 = (new Point(point.X - 50, point.Y - 50));
            p6 = (new Point(point.X + 50, point.Y + 50));
            p7 = (new Point(point.X + 50, point.Y - 50));
            p8 = (new Point(point.X - 50, point.Y + 50));

            pb1 = findpb(p1);
            pb2 = findpb(p2);
            pb3 = findpb(p3);
            pb4 = findpb(p4);
            pb5 = findpb(p5);
            pb6 = findpb(p6);
            pb7 = findpb(p7);
            pb8 = findpb(p8);

            if (sqrcheck(p1) == false) { pb1.BackColor = Color.LightBlue; } else { if (s == "w") { if (sqrcheck_black(p1) == true) { pb1.BackColor = Color.LightPink; } } else { if (sqrcheck_white(p1) == true) { pb1.BackColor = Color.LightPink; } } }
            if (sqrcheck(p2) == false) { pb2.BackColor = Color.LightBlue; } else { if (s == "w") { if (sqrcheck_black(p2) == true) { pb2.BackColor = Color.LightPink; } } else { if (sqrcheck_white(p2) == true) { pb2.BackColor = Color.LightPink; } } } 
            if (sqrcheck(p3) == false) { pb3.BackColor = Color.LightBlue; } else { if (s == "w") { if (sqrcheck_black(p3) == true) { pb3.BackColor = Color.LightPink; } } else { if (sqrcheck_white(p3) == true) { pb3.BackColor = Color.LightPink; } } } 
            if (sqrcheck(p4) == false) { pb4.BackColor = Color.LightBlue; } else { if (s == "w") { if (sqrcheck_black(p4) == true) { pb4.BackColor = Color.LightPink; } } else { if (sqrcheck_white(p4) == true) { pb4.BackColor = Color.LightPink; } } }
            if (sqrcheck(p5) == false) { pb5.BackColor = Color.LightBlue; } else { if (s == "w") { if (sqrcheck_black(p5) == true) { pb5.BackColor = Color.LightPink; } } else { if (sqrcheck_white(p5) == true) { pb5.BackColor = Color.LightPink; } } }
            if (sqrcheck(p6) == false) { pb6.BackColor = Color.LightBlue; } else { if (s == "w") { if (sqrcheck_black(p6) == true) { pb6.BackColor = Color.LightPink; } } else { if (sqrcheck_white(p6) == true) { pb6.BackColor = Color.LightPink; } } }
            if (sqrcheck(p7) == false) { pb7.BackColor = Color.LightBlue; } else { if (s == "w") { if (sqrcheck_black(p7) == true) { pb7.BackColor = Color.LightPink; } } else { if (sqrcheck_white(p7) == true) { pb7.BackColor = Color.LightPink; } } }
            if (sqrcheck(p8) == false) { pb8.BackColor = Color.LightBlue; } else { if (s == "w") { if (sqrcheck_black(p8) == true) { pb8.BackColor = Color.LightPink; } } else { if (sqrcheck_white(p8) == true) { pb8.BackColor = Color.LightPink; } } }
        }

        private void queenmove(Point point, string s)
        {
            rookmove(point, s);
            bishopmove(point, s);
        }

        private void bishopmove(Point point, string s)
        {
            p1 = (new Point(point.X + 50, point.Y + 50));
            p2 = (new Point(point.X + 100, point.Y + 100));
            p3 = (new Point(point.X + 150, point.Y + 150));
            p4 = (new Point(point.X + 200, point.Y + 200));
            p5 = (new Point(point.X + 250, point.Y + 250));
            p6 = (new Point(point.X + 300, point.Y + 300));
            p7 = (new Point(point.X + 350, point.Y + 350));
            rook(point, s);

            p1 = (new Point(point.X - 50, point.Y - 50));
            p2 = (new Point(point.X - 100, point.Y - 100));
            p3 = (new Point(point.X - 150, point.Y - 150));
            p4 = (new Point(point.X - 200, point.Y - 200));
            p5 = (new Point(point.X - 250, point.Y - 250));
            p6 = (new Point(point.X - 300, point.Y - 300));
            p7 = (new Point(point.X - 350, point.Y - 350));
            rook(point, s);

            p1 = (new Point(point.X + 50, point.Y - 50));
            p2 = (new Point(point.X + 100, point.Y - 100));
            p3 = (new Point(point.X + 150, point.Y - 150));
            p4 = (new Point(point.X + 200, point.Y - 200));
            p5 = (new Point(point.X + 250, point.Y - 250));
            p6 = (new Point(point.X + 300, point.Y - 300));
            p7 = (new Point(point.X + 350, point.Y - 350));
            rook(point, s);

            p1 = (new Point(point.X - 50, point.Y + 50));
            p2 = (new Point(point.X - 100, point.Y + 100));
            p3 = (new Point(point.X - 150, point.Y + 150));
            p4 = (new Point(point.X - 200, point.Y + 200));
            p5 = (new Point(point.X - 250, point.Y + 250));
            p6 = (new Point(point.X - 300, point.Y + 300));
            p7 = (new Point(point.X - 350, point.Y + 350));
            rook(point, s);

        }

        private void knightmove(Point point, string s)
        {
            
            p1 = (new Point(point.X - 50, point.Y - 100));
            p2 = (new Point(point.X + 50, point.Y - 100));
            p3 = (new Point(point.X + 100, point.Y - 50));
            p4 = (new Point(point.X + 100, point.Y + 50));
            p5 = (new Point(point.X + 50, point.Y + 100));
            p6 = (new Point(point.X - 50, point.Y + 100));
            p7 = (new Point(point.X - 100, point.Y + 50));
            p8 = (new Point(point.X - 100, point.Y - 50));

            pb1 = findpb(p1);
            pb2 = findpb(p2);
            pb3 = findpb(p3);
            pb4 = findpb(p4);
            pb5 = findpb(p5);
            pb6 = findpb(p6);
            pb7 = findpb(p7);
            pb8 = findpb(p8);

            if (sqrcheck(p1) == false) { pb1.BackColor = Color.LightBlue; } else { if (s == "w") { if (sqrcheck_black(p1) == true) { pb1.BackColor = Color.LightPink; } } else { if (sqrcheck_white(p1) == true) { pb1.BackColor = Color.LightPink; } } }
            if (sqrcheck(p2) == false) { pb2.BackColor = Color.LightBlue; } else { if (s == "w") { if (sqrcheck_black(p2) == true) { pb2.BackColor = Color.LightPink; } } else { if (sqrcheck_white(p2) == true) { pb2.BackColor = Color.LightPink; } } } 
            if (sqrcheck(p3) == false) { pb3.BackColor = Color.LightBlue; } else { if (s == "w") { if (sqrcheck_black(p3) == true) { pb3.BackColor = Color.LightPink; } } else { if (sqrcheck_white(p3) == true) { pb3.BackColor = Color.LightPink; } } } 
            if (sqrcheck(p4) == false) { pb4.BackColor = Color.LightBlue; } else { if (s == "w") { if (sqrcheck_black(p4) == true) { pb4.BackColor = Color.LightPink; } } else { if (sqrcheck_white(p4) == true) { pb4.BackColor = Color.LightPink; } } } 
            if (sqrcheck(p5) == false) { pb5.BackColor = Color.LightBlue; } else { if (s == "w") { if (sqrcheck_black(p5) == true) { pb5.BackColor = Color.LightPink; } } else { if (sqrcheck_white(p5) == true) { pb5.BackColor = Color.LightPink; } } } 
            if (sqrcheck(p6) == false) { pb6.BackColor = Color.LightBlue; } else { if (s == "w") { if (sqrcheck_black(p6) == true) { pb6.BackColor = Color.LightPink; } } else { if (sqrcheck_white(p6) == true) { pb6.BackColor = Color.LightPink; } } } 
            if (sqrcheck(p7) == false) { pb7.BackColor = Color.LightBlue; } else { if (s == "w") { if (sqrcheck_black(p7) == true) { pb7.BackColor = Color.LightPink; } } else { if (sqrcheck_white(p7) == true) { pb7.BackColor = Color.LightPink; } } }
            if (sqrcheck(p8) == false) { pb8.BackColor = Color.LightBlue; } else { if (s == "w") { if (sqrcheck_black(p8) == true) { pb8.BackColor = Color.LightPink; } } else { if (sqrcheck_white(p8) == true) { pb8.BackColor = Color.LightPink; } } }
        }

        private void pawnmove(Point point, string s, Point dm)
        {
            p0 = (new Point(point.X, point.Y - 100));
            p1 = (new Point(point.X, point.Y - 50));
            p2 = (new Point(point.X - 50, point.Y - 50));
            p3 = (new Point(point.X + 50, point.Y - 50));
            pb0 = findpb(p0);
            pb1 = findpb(p1);
            pb2 = findpb(p2);
            pb3 = findpb(p3);

            if (sqrcheck(p1) == false)
            {
                pb1.BackColor = Color.LightBlue;

                if (sqrcheck(p0) == false && point == dm)
                {
                    pb0.BackColor = Color.LightBlue;
                }
            }

            if (s == "b")
            {
                if (sqrcheck_white(p2) == true) { pb2.BackColor = Color.LightPink; }
                if (sqrcheck_white(p3) == true) { pb3.BackColor = Color.LightPink; }
            }

            if (s == "w")
            {
                if (sqrcheck_black(p2) == true) { pb2.BackColor = Color.LightPink; }
                if (sqrcheck_black(p3) == true) { pb3.BackColor = Color.LightPink; }
            }

        }

        private void rook(Point point, string s)
        {
             ex1 = true;
             ex2 = true;
             ex3 = true;
             ex4 = true;
             ex5 = true;
             ex6 = true;
             pb1 = findpb(p1);
             pb2 = findpb(p2);
             pb3 = findpb(p3);
             pb4 = findpb(p4);
             pb5 = findpb(p5);
             pb6 = findpb(p6);
             pb7 = findpb(p7);

            if (sqrcheck(p1) == false) { pb1.BackColor = Color.LightBlue; ex1 = false; } else { if (s == "w") { if (sqrcheck_black(p1) == true) { pb1.BackColor = Color.LightPink; } } else { if (sqrcheck_white(p1) == true) { pb1.BackColor = Color.LightPink; } } }
            if (ex1 == false) { if (sqrcheck(p2) == false) { pb2.BackColor = Color.LightBlue; ex2 = false; } else { if (s == "w") { if (sqrcheck_black(p2) == true) { pb2.BackColor = Color.LightPink; } } else { if (sqrcheck_white(p2) == true) { pb2.BackColor = Color.LightPink; } } } }
            if (ex2 == false) { if (sqrcheck(p3) == false) { pb3.BackColor = Color.LightBlue; ex3 = false; } else { if (s == "w") { if (sqrcheck_black(p3) == true) { pb3.BackColor = Color.LightPink; } } else { if (sqrcheck_white(p3) == true) { pb3.BackColor = Color.LightPink; } } } }
            if (ex3 == false) { if (sqrcheck(p4) == false) { pb4.BackColor = Color.LightBlue; ex4 = false; } else { if (s == "w") { if (sqrcheck_black(p4) == true) { pb4.BackColor = Color.LightPink; } } else { if (sqrcheck_white(p4) == true) { pb4.BackColor = Color.LightPink; } } } }
            if (ex4 == false) { if (sqrcheck(p5) == false) { pb5.BackColor = Color.LightBlue; ex5 = false; } else { if (s == "w") { if (sqrcheck_black(p5) == true) { pb5.BackColor = Color.LightPink; } } else { if (sqrcheck_white(p5) == true) { pb5.BackColor = Color.LightPink; } } } }
            if (ex5 == false) { if (sqrcheck(p6) == false) { pb6.BackColor = Color.LightBlue; ex6 = false; } else { if (s == "w") { if (sqrcheck_black(p6) == true) { pb6.BackColor = Color.LightPink; } } else { if (sqrcheck_white(p6) == true) { pb6.BackColor = Color.LightPink; } } } }
            if (ex6 == false) { if (sqrcheck(p7) == false) { pb7.BackColor = Color.LightBlue; } else { if (s == "w") { if (sqrcheck_black(p7) == true) { pb7.BackColor = Color.LightPink; } } else { if (sqrcheck_white(p7) == true) { pb7.BackColor = Color.LightPink; } } } }
        }

        private void rookmove(Point point, string s)
        {
            p1 = (new Point(point.X + 50, point.Y));
            p2 = (new Point(point.X + 100, point.Y));
            p3 = (new Point(point.X + 150, point.Y));
            p4 = (new Point(point.X + 200, point.Y));
            p5 = (new Point(point.X + 250, point.Y));
            p6 = (new Point(point.X + 300, point.Y));
            p7 = (new Point(point.X + 350, point.Y));
            rook(point, s);

            p1 = (new Point(point.X - 50, point.Y));
            p2 = (new Point(point.X - 100, point.Y));
            p3 = (new Point(point.X - 150, point.Y));
            p4 = (new Point(point.X - 200, point.Y));
            p5 = (new Point(point.X - 250, point.Y));
            p6 = (new Point(point.X - 300, point.Y));
            p7 = (new Point(point.X - 350, point.Y));
            rook(point, s);

            p1 = (new Point(point.X, point.Y + 50));
            p2 = (new Point(point.X, point.Y + 100));
            p3 = (new Point(point.X, point.Y + 150));
            p4 = (new Point(point.X, point.Y + 200));
            p5 = (new Point(point.X, point.Y + 250));
            p6 = (new Point(point.X, point.Y + 300));
            p7 = (new Point(point.X, point.Y + 350));
            rook(point, s);

            p1 = (new Point(point.X, point.Y - 50));
            p2 = (new Point(point.X, point.Y - 100));
            p3 = (new Point(point.X, point.Y - 150));
            p4 = (new Point(point.X, point.Y - 200));
            p5 = (new Point(point.X, point.Y - 250));
            p6 = (new Point(point.X, point.Y - 300));
            p7 = (new Point(point.X, point.Y - 350));
            rook(point, s);

        }
        
        private void combatmix(PictureBox pb, Point pb_xy)
        {
            if (pb != pictureBox_blackpawn1) { combat(pictureBox_blackpawn1, BlackPawn1_selected, pb, BlackPawn1_xy, pb_xy); }
            if (pb != pictureBox_blackpawn2) combat(pictureBox_blackpawn2, BlackPawn2_selected, pb, BlackPawn1_xy, pb_xy);
            if (pb != pictureBox_blackpawn3) combat(pictureBox_blackpawn3, BlackPawn3_selected, pb, BlackPawn1_xy, pb_xy);
            if (pb != pictureBox_blackpawn4) combat(pictureBox_blackpawn4, BlackPawn4_selected, pb, BlackPawn1_xy, pb_xy);
            if (pb != pictureBox_blackpawn5) combat(pictureBox_blackpawn5, BlackPawn5_selected, pb, BlackPawn1_xy, pb_xy);
            if (pb != pictureBox_blackpawn6) combat(pictureBox_blackpawn6, BlackPawn6_selected, pb, BlackPawn1_xy, pb_xy);
            if (pb != pictureBox_blackpawn7) combat(pictureBox_blackpawn7, BlackPawn7_selected, pb, BlackPawn1_xy, pb_xy);
            if (pb != pictureBox_blackpawn8) combat(pictureBox_blackpawn8, BlackPawn8_selected, pb, BlackPawn1_xy, pb_xy);

            if (pb != pictureBox_blackrook1) combat(pictureBox_blackrook1, BlackRook1_selected, pb, BlackRook1_xy, pb_xy);
            if (pb != pictureBox_blackknight1) combat(pictureBox_blackknight1, BlackKnight1_selected, pb, BlackKnight1_xy, pb_xy);
            if (pb != pictureBox_blackbishop1) combat(pictureBox_blackbishop1, BlackBishop1_selected, pb, BlackBishop1_xy, pb_xy);
            if (pb != pictureBox_blackqueen) combat(pictureBox_blackqueen, BlackQueen_selected, pb, BlackQueen_xy, pb_xy);
            if (pb != pictureBox_blackking) combat(pictureBox_blackking, BlackKing_selected, pb, BlackKing_xy, pb_xy);
            if (pb != pictureBox_blackbishop2) combat(pictureBox_blackbishop2, BlackBishop2_selected, pb, BlackBishop2_xy, pb_xy);
            if (pb != pictureBox_blackknight2) combat(pictureBox_blackknight2, BlackKnight2_selected, pb, BlackKnight2_xy, pb_xy);
            if (pb != pictureBox_blackrook2) combat(pictureBox_blackrook2, BlackRook2_selected, pb, BlackRook2_xy, pb_xy);

            if (pb != pictureBox_whitepawn1) { combat(pictureBox_whitepawn1, WhitePawn1_selected, pb, WhitePawn1_xy, pb_xy); }
            if (pb != pictureBox_whitepawn2) combat(pictureBox_whitepawn2, WhitePawn2_selected, pb, WhitePawn1_xy, pb_xy);
            if (pb != pictureBox_whitepawn3) combat(pictureBox_whitepawn3, WhitePawn3_selected, pb, WhitePawn1_xy, pb_xy);
            if (pb != pictureBox_whitepawn4) combat(pictureBox_whitepawn4, WhitePawn4_selected, pb, WhitePawn1_xy, pb_xy);
            if (pb != pictureBox_whitepawn5) combat(pictureBox_whitepawn5, WhitePawn5_selected, pb, WhitePawn1_xy, pb_xy);
            if (pb != pictureBox_whitepawn6) combat(pictureBox_whitepawn6, WhitePawn6_selected, pb, WhitePawn1_xy, pb_xy);
            if (pb != pictureBox_whitepawn7) combat(pictureBox_whitepawn7, WhitePawn7_selected, pb, WhitePawn1_xy, pb_xy);
            if (pb != pictureBox_whitepawn8) combat(pictureBox_whitepawn8, WhitePawn8_selected, pb, WhitePawn1_xy, pb_xy);

            if (pb != pictureBox_whiterook1) combat(pictureBox_whiterook1, WhiteRook1_selected, pb, WhiteRook1_xy, pb_xy);
            if (pb != pictureBox_whiteknight1) combat(pictureBox_whiteknight1, WhiteKnight1_selected, pb, WhiteKnight1_xy, pb_xy);
            if (pb != pictureBox_whitebishop1) combat(pictureBox_whitebishop1, WhiteBishop1_selected, pb, WhiteBishop1_xy, pb_xy);
            if (pb != pictureBox_whitequeen) combat(pictureBox_whitequeen, WhiteQueen_selected, pb, WhiteQueen_xy, pb_xy);
            if (pb != pictureBox_whiteking) combat(pictureBox_whiteking, WhiteKing_selected, pb, WhiteKing_xy, pb_xy);
            if (pb != pictureBox_whitebishop2) combat(pictureBox_whitebishop2, WhiteBishop2_selected, pb, WhiteBishop2_xy, pb_xy);
            if (pb != pictureBox_whiteknight2) combat(pictureBox_whiteknight2, WhiteKnight2_selected, pb, WhiteKnight2_xy, pb_xy);
            if (pb != pictureBox_whiterook2) combat(pictureBox_whiterook2, WhiteRook2_selected, pb, WhiteRook2_xy, pb_xy);

        }

        //Move x pb to y cordinate
        private void move(PictureBox pb, bool pb_selected, Point pb_xy, Point sqr)
        {
            
            //a
            if (sqr == a1c) { temp = pictureBox_a1; }
            if (sqr == a2c) { temp = pictureBox_a2; }
            if (sqr == a3c) { temp = pictureBox_a3; }
            if (sqr == a4c) { temp = pictureBox_a4; }
            if (sqr == a5c) { temp = pictureBox_a5; }
            if (sqr == a6c) { temp = pictureBox_a6; }
            if (sqr == a7c) { temp = pictureBox_a7; }
            if (sqr == a8c) { temp = pictureBox_a8; }
            //b
            if (sqr == b1c) { temp = pictureBox_b1; }
            if (sqr == b2c) { temp = pictureBox_b2; }
            if (sqr == b3c) { temp = pictureBox_b3; }
            if (sqr == b4c) { temp = pictureBox_b4; }
            if (sqr == b5c) { temp = pictureBox_b5; }
            if (sqr == b6c) { temp = pictureBox_b6; }
            if (sqr == b7c) { temp = pictureBox_b7; }
            if (sqr == b8c) { temp = pictureBox_b8; }
            //c
            if (sqr == c1c) { temp = pictureBox_c1; }
            if (sqr == c2c) { temp = pictureBox_c2; }
            if (sqr == c3c) { temp = pictureBox_c3; }
            if (sqr == c4c) { temp = pictureBox_c4; }
            if (sqr == c5c) { temp = pictureBox_c5; }
            if (sqr == c6c) { temp = pictureBox_c6; }
            if (sqr == c7c) { temp = pictureBox_c7; }
            if (sqr == c8c) { temp = pictureBox_c8; }
            //d
            if (sqr == d1c) { temp = pictureBox_d1; }
            if (sqr == d2c) { temp = pictureBox_d2; }
            if (sqr == d3c) { temp = pictureBox_d3; }
            if (sqr == d4c) { temp = pictureBox_d4; }
            if (sqr == d5c) { temp = pictureBox_d5; }
            if (sqr == d6c) { temp = pictureBox_d6; }
            if (sqr == d7c) { temp = pictureBox_d7; }
            if (sqr == d8c) { temp = pictureBox_d8; }
            //e
            if (sqr == e1c) { temp = pictureBox_e1; }
            if (sqr == e2c) { temp = pictureBox_e2; }
            if (sqr == e3c) { temp = pictureBox_e3; }
            if (sqr == e4c) { temp = pictureBox_e4; }
            if (sqr == e5c) { temp = pictureBox_e5; }
            if (sqr == e6c) { temp = pictureBox_e6; }
            if (sqr == e7c) { temp = pictureBox_e7; }
            if (sqr == e8c) { temp = pictureBox_e8; }
            //f
            if (sqr == f1c) { temp = pictureBox_f1; }
            if (sqr == f2c) { temp = pictureBox_f2; }
            if (sqr == f3c) { temp = pictureBox_f3; }
            if (sqr == f4c) { temp = pictureBox_f4; }
            if (sqr == f5c) { temp = pictureBox_f5; }
            if (sqr == f6c) { temp = pictureBox_f6; }
            if (sqr == f7c) { temp = pictureBox_f7; }
            if (sqr == f8c) { temp = pictureBox_f8; }
            //g
            if (sqr == g1c) { temp = pictureBox_g1; }
            if (sqr == g2c) { temp = pictureBox_g2; }
            if (sqr == g3c) { temp = pictureBox_g3; }
            if (sqr == g4c) { temp = pictureBox_g4; }
            if (sqr == g5c) { temp = pictureBox_g5; }
            if (sqr == g6c) { temp = pictureBox_g6; }
            if (sqr == g7c) { temp = pictureBox_g7; }
            if (sqr == g8c) { temp = pictureBox_g8; }
            //h
            if (sqr == h1c) { temp = pictureBox_h1; }
            if (sqr == h2c) { temp = pictureBox_h2; }
            if (sqr == h3c) { temp = pictureBox_h3; }
            if (sqr == h4c) { temp = pictureBox_h4; }
            if (sqr == h5c) { temp = pictureBox_h5; }
            if (sqr == h6c) { temp = pictureBox_h6; }
            if (sqr == h7c) { temp = pictureBox_h7; }
            if (sqr == h8c) { temp = pictureBox_h8; }


            if (temp.BackColor == Color.LightBlue)
            {
                if (sqrcheck(sqr) == false)
                {
                    if (pb_selected == true)
                    {
                        
                        resetsqrs();
                        clrselected();
                        clrtoogle();
                        pb.Location = sqr;

                        if (pb == pictureBox_blackpawn1) { BlackPawn1_xy = sqr; pawnmove(BlackPawn1_xy, "b", b1c); if (findpb(WhiteKing_xy).BackColor == Color.LightPink) { Chess_White = true; } clrselected(); clrtoogle(); resetsqrs(); }
                        if (pb == pictureBox_blackpawn2) { BlackPawn2_xy = sqr; pawnmove(BlackPawn2_xy, "b", b2c); if (findpb(WhiteKing_xy).BackColor == Color.LightPink) { Chess_White = true; } clrselected(); clrtoogle(); resetsqrs(); }
                        if (pb == pictureBox_blackpawn3) { BlackPawn3_xy = sqr; pawnmove(BlackPawn3_xy, "b", b3c); if (findpb(WhiteKing_xy).BackColor == Color.LightPink) { Chess_White = true; } clrselected(); clrtoogle(); resetsqrs(); }
                        if (pb == pictureBox_blackpawn4) { BlackPawn4_xy = sqr; pawnmove(BlackPawn4_xy, "b", b4c); if (findpb(WhiteKing_xy).BackColor == Color.LightPink) { Chess_White = true; } clrselected(); clrtoogle(); resetsqrs(); }
                        if (pb == pictureBox_blackpawn5) { BlackPawn5_xy = sqr; pawnmove(BlackPawn5_xy, "b", b5c); if (findpb(WhiteKing_xy).BackColor == Color.LightPink) { Chess_White = true; } clrselected(); clrtoogle(); resetsqrs(); }
                        if (pb == pictureBox_blackpawn6) { BlackPawn6_xy = sqr; pawnmove(BlackPawn6_xy, "b", b6c); if (findpb(WhiteKing_xy).BackColor == Color.LightPink) { Chess_White = true; } clrselected(); clrtoogle(); resetsqrs(); }
                        if (pb == pictureBox_blackpawn7) { BlackPawn7_xy = sqr; pawnmove(BlackPawn7_xy, "b", b7c); if (findpb(WhiteKing_xy).BackColor == Color.LightPink) { Chess_White = true; } clrselected(); clrtoogle(); resetsqrs(); }
                        if (pb == pictureBox_blackpawn8) { BlackPawn8_xy = sqr; pawnmove(BlackPawn8_xy, "b", b8c); if (findpb(WhiteKing_xy).BackColor == Color.LightPink) { Chess_White = true; } clrselected(); clrtoogle(); resetsqrs(); }
                        if (pb == pictureBox_blackrook1)
                        {
                            BlackRook1_xy = sqr;
                            rookmove(BlackRook1_xy, "b");
                            if (findpb(WhiteKing_xy).BackColor == Color.LightPink) { Chess_White = true; }
                            clrselected();
                            clrtoogle();
                            resetsqrs();
                        }
                        if (pb == pictureBox_blackknight1)
                        {
                            BlackKnight1_xy = sqr;
                            knightmove(BlackKnight1_xy, "b");
                            if (findpb(WhiteKing_xy).BackColor == Color.LightPink) { Chess_White = true; }
                            clrselected();
                            clrtoogle();
                            resetsqrs();
                        }
                        if (pb == pictureBox_blackbishop1)
                        {
                            BlackBishop1_xy = sqr;
                            bishopmove(BlackBishop1_xy, "b");
                            if (findpb(WhiteKing_xy).BackColor == Color.LightPink) { Chess_White = true; }
                            clrselected(); clrtoogle(); resetsqrs();
                        }
                        if (pb == pictureBox_blackqueen)
                        {
                            BlackQueen_xy = sqr;
                            queenmove(BlackQueen_xy, "b");
                            if (findpb(WhiteKing_xy).BackColor == Color.LightPink) { Chess_White = true; }
                            clrselected(); clrtoogle(); resetsqrs();
                        }
                        if (pb == pictureBox_blackking)
                        {
                            BlackKing_xy = sqr;
                        }
                        if (pb == pictureBox_blackbishop2)
                        {
                            BlackBishop2_xy = sqr;
                            bishopmove(BlackBishop2_xy, "b");
                            if (findpb(WhiteKing_xy).BackColor == Color.LightPink) { Chess_White = true; }
                            clrselected(); clrtoogle(); resetsqrs();
                        }
                        if (pb == pictureBox_blackknight2)
                        {
                            BlackKnight2_xy = sqr;
                            knightmove(BlackKnight2_xy, "b");
                            if (findpb(WhiteKing_xy).BackColor == Color.LightPink) { Chess_White = true; }
                            clrselected(); clrtoogle(); resetsqrs();
                        }
                        if (pb == pictureBox_blackrook2)
                        {
                            BlackRook2_xy = sqr;
                            rookmove(BlackRook2_xy, "b");
                            if (findpb(WhiteKing_xy).BackColor == Color.LightPink) { Chess_White = true; }
                            clrselected(); clrtoogle(); resetsqrs();
                        }

                        if (pb == pictureBox_whitepawn1)
                        {
                            WhitePawn1_xy = sqr;
                            pawnmove(WhitePawn1_xy, "w", g1c); if (findpb(BlackKing_xy).BackColor == Color.LightPink) { Chess_Black = true; }
                            clrselected(); clrtoogle(); resetsqrs();

                        }
                        if (pb == pictureBox_whitepawn2)
                        {
                            WhitePawn2_xy = sqr;
                            pawnmove(WhitePawn2_xy, "w", g1c); if (findpb(BlackKing_xy).BackColor == Color.LightPink) { Chess_Black = true; }
                            clrselected(); clrtoogle(); resetsqrs();
                        }
                        if (pb == pictureBox_whitepawn3)
                        {
                            WhitePawn3_xy = sqr;
                            pawnmove(WhitePawn3_xy, "w", g1c); if (findpb(BlackKing_xy).BackColor == Color.LightPink) { Chess_Black = true; }
                            clrselected(); clrtoogle(); resetsqrs();
                        }
                        if (pb == pictureBox_whitepawn4)
                        {
                            WhitePawn4_xy = sqr;
                            pawnmove(WhitePawn4_xy, "w", g1c); if (findpb(BlackKing_xy).BackColor == Color.LightPink) { Chess_Black = true; }
                            clrselected(); clrtoogle(); resetsqrs();
                        }
                        if (pb == pictureBox_whitepawn5)
                        {
                            WhitePawn5_xy = sqr;
                            pawnmove(WhitePawn5_xy, "w", g1c); if (findpb(BlackKing_xy).BackColor == Color.LightPink) { Chess_Black = true; }
                            clrselected(); clrtoogle(); resetsqrs();
                        }
                        if (pb == pictureBox_whitepawn6)
                        {
                            WhitePawn6_xy = sqr;
                            pawnmove(WhitePawn6_xy, "w", g1c); if (findpb(BlackKing_xy).BackColor == Color.LightPink) { Chess_Black = true; }
                            clrselected(); clrtoogle(); resetsqrs();
                        }
                        if (pb == pictureBox_whitepawn7)
                        {
                            WhitePawn7_xy = sqr;
                            pawnmove(WhitePawn7_xy, "w", g1c); if (findpb(BlackKing_xy).BackColor == Color.LightPink) { Chess_Black = true; }
                            clrselected(); clrtoogle(); resetsqrs();
                        }
                        if (pb == pictureBox_whitepawn8)
                        {
                            WhitePawn8_xy = sqr;
                            pawnmove(WhitePawn8_xy, "w", g1c); if (findpb(BlackKing_xy).BackColor == Color.LightPink) { Chess_Black = true; }
                            clrselected(); clrtoogle(); resetsqrs();
                        }
                        if (pb == pictureBox_whiterook1)
                        {
                            WhiteRook1_xy = sqr;
                            rookmove(WhiteRook1_xy, "w");
                            if (findpb(BlackKing_xy).BackColor == Color.LightPink) { Chess_Black = true; }
                            clrselected();
                            clrtoogle();
                            resetsqrs();
                        }
                        if (pb == pictureBox_whiteknight1)
                        {
                            WhiteKnight1_xy = sqr;
                            knightmove(WhiteKnight1_xy, "w");
                            if (findpb(BlackKing_xy).BackColor == Color.LightPink) { Chess_Black = true; }
                            clrselected();
                            clrtoogle();
                            resetsqrs();
                        }
                        if (pb == pictureBox_whitebishop1)
                        {
                            WhiteBishop1_xy = sqr;
                            bishopmove(WhiteBishop1_xy, "w");
                            if (findpb(BlackKing_xy).BackColor == Color.LightPink) { Chess_Black = true; }
                            clrselected(); clrtoogle(); resetsqrs();
                        }
                        if (pb == pictureBox_whitequeen)
                        {
                            WhiteQueen_xy = sqr;
                            queenmove(WhiteQueen_xy, "w");
                            if (findpb(BlackKing_xy).BackColor == Color.LightPink) { Chess_Black = true; }
                            clrselected(); clrtoogle(); resetsqrs();
                        }
                        if (pb == pictureBox_whiteking)
                        {
                            WhiteKing_xy = sqr;
                        }
                        if (pb == pictureBox_whitebishop2)
                        {
                            WhiteBishop2_xy = sqr;
                            bishopmove(WhiteBishop2_xy, "w");
                            if (findpb(BlackKing_xy).BackColor == Color.LightPink) { Chess_Black = true; }
                            clrselected(); clrtoogle(); resetsqrs();
                        }
                        if (pb == pictureBox_whiteknight2)
                        {
                            WhiteKnight2_xy = sqr;
                            knightmove(WhiteKnight2_xy, "w");
                            if (findpb(BlackKing_xy).BackColor == Color.LightPink) { Chess_Black = true; }
                            clrselected(); clrtoogle(); resetsqrs();
                        }
                        if (pb == pictureBox_whiterook2)
                        {
                            WhiteRook2_xy = sqr;
                            rookmove(WhiteRook2_xy, "w");
                            if (findpb(BlackKing_xy).BackColor == Color.LightPink) { Chess_Black = true; }
                            clrselected(); clrtoogle(); resetsqrs();
                        }

                        if (Chess_Black == true) { label1.Text = "Chess!"; }
                        if (Chess_White == true) { label2.Text = "Chess!"; }
                        Rotate();
                        blackturn = !blackturn;
                        whiteturn = !whiteturn;
                    }
                }
            }
        }
        //Move x pb to y cordinate

        //Check if x pb standing on sqr, sqr is Pink?
        public bool colorcheck(Point xy)
        {
            bool value = false;
            if (xy == a1c) { if (pictureBox_a1.BackColor == Color.LightPink) { value = true; } }
            if (xy == a2c) { if (pictureBox_a2.BackColor == Color.LightPink) { value = true; } }
            if (xy == a3c) { if (pictureBox_a3.BackColor == Color.LightPink) { value = true; } }
            if (xy == a4c) { if (pictureBox_a4.BackColor == Color.LightPink) { value = true; } }
            if (xy == a5c) { if (pictureBox_a5.BackColor == Color.LightPink) { value = true; } }
            if (xy == a6c) { if (pictureBox_a6.BackColor == Color.LightPink) { value = true; } }
            if (xy == a7c) { if (pictureBox_a7.BackColor == Color.LightPink) { value = true; } }
            if (xy == a8c) { if (pictureBox_a8.BackColor == Color.LightPink) { value = true; } }

            if (xy == b1c) { if (pictureBox_b1.BackColor == Color.LightPink) { value = true; } }
            if (xy == b2c) { if (pictureBox_b2.BackColor == Color.LightPink) { value = true; } }
            if (xy == b3c) { if (pictureBox_b3.BackColor == Color.LightPink) { value = true; } }
            if (xy == b4c) { if (pictureBox_b4.BackColor == Color.LightPink) { value = true; } }
            if (xy == b5c) { if (pictureBox_b5.BackColor == Color.LightPink) { value = true; } }
            if (xy == b6c) { if (pictureBox_b6.BackColor == Color.LightPink) { value = true; } }
            if (xy == b7c) { if (pictureBox_b7.BackColor == Color.LightPink) { value = true; } }
            if (xy == b8c) { if (pictureBox_b8.BackColor == Color.LightPink) { value = true; } }

            if (xy == c1c) { if (pictureBox_c1.BackColor == Color.LightPink) { value = true; } }
            if (xy == c2c) { if (pictureBox_c2.BackColor == Color.LightPink) { value = true; } }
            if (xy == c3c) { if (pictureBox_c3.BackColor == Color.LightPink) { value = true; } }
            if (xy == c4c) { if (pictureBox_c4.BackColor == Color.LightPink) { value = true; } }
            if (xy == c5c) { if (pictureBox_c5.BackColor == Color.LightPink) { value = true; } }
            if (xy == c6c) { if (pictureBox_c6.BackColor == Color.LightPink) { value = true; } }
            if (xy == c7c) { if (pictureBox_c7.BackColor == Color.LightPink) { value = true; } }
            if (xy == c8c) { if (pictureBox_c8.BackColor == Color.LightPink) { value = true; } }

            if (xy == d1c) { if (pictureBox_d1.BackColor == Color.LightPink) { value = true; } }
            if (xy == d2c) { if (pictureBox_d2.BackColor == Color.LightPink) { value = true; } }
            if (xy == d3c) { if (pictureBox_d3.BackColor == Color.LightPink) { value = true; } }
            if (xy == d4c) { if (pictureBox_d4.BackColor == Color.LightPink) { value = true; } }
            if (xy == d5c) { if (pictureBox_d5.BackColor == Color.LightPink) { value = true; } }
            if (xy == d6c) { if (pictureBox_d6.BackColor == Color.LightPink) { value = true; } }
            if (xy == d7c) { if (pictureBox_d7.BackColor == Color.LightPink) { value = true; } }
            if (xy == d8c) { if (pictureBox_d8.BackColor == Color.LightPink) { value = true; } }

            if (xy == e1c) { if (pictureBox_e1.BackColor == Color.LightPink) { value = true; } }
            if (xy == e2c) { if (pictureBox_e2.BackColor == Color.LightPink) { value = true; } }
            if (xy == e3c) { if (pictureBox_e3.BackColor == Color.LightPink) { value = true; } }
            if (xy == e4c) { if (pictureBox_e4.BackColor == Color.LightPink) { value = true; } }
            if (xy == e5c) { if (pictureBox_e5.BackColor == Color.LightPink) { value = true; } }
            if (xy == e6c) { if (pictureBox_e6.BackColor == Color.LightPink) { value = true; } }
            if (xy == e7c) { if (pictureBox_e7.BackColor == Color.LightPink) { value = true; } }
            if (xy == e8c) { if (pictureBox_e8.BackColor == Color.LightPink) { value = true; } }

            if (xy == f1c) { if (pictureBox_f1.BackColor == Color.LightPink) { value = true; } }
            if (xy == f2c) { if (pictureBox_f2.BackColor == Color.LightPink) { value = true; } }
            if (xy == f3c) { if (pictureBox_f3.BackColor == Color.LightPink) { value = true; } }
            if (xy == f4c) { if (pictureBox_f4.BackColor == Color.LightPink) { value = true; } }
            if (xy == f5c) { if (pictureBox_f5.BackColor == Color.LightPink) { value = true; } }
            if (xy == f6c) { if (pictureBox_f6.BackColor == Color.LightPink) { value = true; } }
            if (xy == f7c) { if (pictureBox_f7.BackColor == Color.LightPink) { value = true; } }
            if (xy == f8c) { if (pictureBox_f8.BackColor == Color.LightPink) { value = true; } }

            if (xy == g1c) { if (pictureBox_g1.BackColor == Color.LightPink) { value = true; } }
            if (xy == g2c) { if (pictureBox_g2.BackColor == Color.LightPink) { value = true; } }
            if (xy == g3c) { if (pictureBox_g3.BackColor == Color.LightPink) { value = true; } }
            if (xy == g4c) { if (pictureBox_g4.BackColor == Color.LightPink) { value = true; } }
            if (xy == g5c) { if (pictureBox_g5.BackColor == Color.LightPink) { value = true; } }
            if (xy == g6c) { if (pictureBox_g6.BackColor == Color.LightPink) { value = true; } }
            if (xy == g7c) { if (pictureBox_g7.BackColor == Color.LightPink) { value = true; } }
            if (xy == g8c) { if (pictureBox_g8.BackColor == Color.LightPink) { value = true; } }

            if (xy == h1c) { if (pictureBox_h1.BackColor == Color.LightPink) { value = true; } }
            if (xy == h2c) { if (pictureBox_h2.BackColor == Color.LightPink) { value = true; } }
            if (xy == h3c) { if (pictureBox_h3.BackColor == Color.LightPink) { value = true; } }
            if (xy == h4c) { if (pictureBox_h4.BackColor == Color.LightPink) { value = true; } }
            if (xy == h5c) { if (pictureBox_h5.BackColor == Color.LightPink) { value = true; } }
            if (xy == h6c) { if (pictureBox_h6.BackColor == Color.LightPink) { value = true; } }
            if (xy == h7c) { if (pictureBox_h7.BackColor == Color.LightPink) { value = true; } }
            if (xy == h8c) { if (pictureBox_h8.BackColor == Color.LightPink) { value = true; } }

            return value;
        }
        //Check if x pb standing on sqr, sqr is Pink?

        //All "toggle bool's" to false
        private void clrtoogle()
        {
            BlackPawn1_toggle = false;
            BlackPawn2_toggle = false;
            BlackPawn3_toggle = false;
            BlackPawn4_toggle = false;
            BlackPawn5_toggle = false;
            BlackPawn6_toggle = false;
            BlackPawn7_toggle = false;
            BlackPawn8_toggle = false;
            BlackRook1_toggle = false;
            BlackKnight1_toggle = false;
            BlackBishop1_toggle = false;
            BlackQueen_toggle = false;
            BlackKing_toggle = false;
            BlackBishop2_toggle = false;
            BlackKnight2_toggle = false;
            BlackRook2_toggle = false;
            WhitePawn1_toggle = false;
            WhitePawn2_toggle = false;
            WhitePawn3_toggle = false;
            WhitePawn4_toggle = false;
            WhitePawn5_toggle = false;
            WhitePawn6_toggle = false;
            WhitePawn7_toggle = false;
            WhitePawn8_toggle = false;
            WhiteRook1_toggle = false;
            WhiteKnight1_toggle = false;
            WhiteBishop1_toggle = false;
            WhiteQueen_toggle = false;
            WhiteKing_toggle = false;
            WhiteBishop2_toggle = false;
            WhiteKnight2_toggle = false;
            WhiteRook2_toggle = false;
        }
        //All "toggle bool's" to false

        //All "selected bool's" to false
        private void clrselected()
        {
             BlackPawn1_selected = false;
             BlackPawn2_selected = false;
             BlackPawn3_selected = false;
             BlackPawn4_selected = false;
             BlackPawn5_selected = false;
             BlackPawn6_selected = false;
             BlackPawn7_selected = false;
             BlackPawn8_selected = false;
             BlackRook1_selected = false;
             BlackKnight1_selected = false;
             BlackBishop1_selected = false;
             BlackQueen_selected = false;
             BlackKing_selected = false;
             BlackBishop2_selected = false;
             BlackKnight2_selected = false;
             BlackRook2_selected = false;
             WhitePawn1_selected = false;
             WhitePawn2_selected = false;
             WhitePawn3_selected = false;
             WhitePawn4_selected = false;
             WhitePawn5_selected = false;
             WhitePawn6_selected = false;
             WhitePawn7_selected = false;
             WhitePawn8_selected = false;
             WhiteRook1_selected = false;
             WhiteKnight1_selected = false;
             WhiteBishop1_selected = false;
             WhiteQueen_selected = false;
             WhiteKing_selected = false;
             WhiteBishop2_selected = false;
             WhiteKnight2_selected = false;
             WhiteRook2_selected = false;
        }
        //All "selected bool's" to false

        //set all squares to default color
        private void resetsqrs()
        {
            //A Stage
            pictureBox_a1.BackColor = a1;
            pictureBox_a2.BackColor = a2;
            pictureBox_a3.BackColor = a3;
            pictureBox_a4.BackColor = a4;
            pictureBox_a5.BackColor = a5;
            pictureBox_a6.BackColor = a6;
            pictureBox_a7.BackColor = a7;
            pictureBox_a8.BackColor = a8;
            //A Stage

            //B Stage
            pictureBox_b1.BackColor = b1;
            pictureBox_b2.BackColor = b2;
            pictureBox_b3.BackColor = b3;
            pictureBox_b4.BackColor = b4;
            pictureBox_b5.BackColor = b5;
            pictureBox_b6.BackColor = b6;
            pictureBox_b7.BackColor = b7;
            pictureBox_b8.BackColor = b8;
            //B Stage

            //C Stage
            pictureBox_c1.BackColor = c1;
            pictureBox_c2.BackColor = c2;
            pictureBox_c3.BackColor = c3;
            pictureBox_c4.BackColor = c4;
            pictureBox_c5.BackColor = c5;
            pictureBox_c6.BackColor = c6;
            pictureBox_c7.BackColor = c7;
            pictureBox_c8.BackColor = c8;
            //C Stag

            //D Stage
            pictureBox_d1.BackColor = d1;
            pictureBox_d2.BackColor = d2;
            pictureBox_d3.BackColor = d3;
            pictureBox_d4.BackColor = d4;
            pictureBox_d5.BackColor = d5;
            pictureBox_d6.BackColor = d6;
            pictureBox_d7.BackColor = d7;
            pictureBox_d8.BackColor = d8;
            //D Stage

            //E Stage
            pictureBox_e1.BackColor = e1;
            pictureBox_e2.BackColor = e2;
            pictureBox_e3.BackColor = e3;
            pictureBox_e4.BackColor = e4;
            pictureBox_e5.BackColor = e5;
            pictureBox_e6.BackColor = e6;
            pictureBox_e7.BackColor = e7;
            pictureBox_e8.BackColor = e8;
            //E Stage

            //F Stage
            pictureBox_f1.BackColor = f1;
            pictureBox_f2.BackColor = f2;
            pictureBox_f3.BackColor = f3;
            pictureBox_f4.BackColor = f4;
            pictureBox_f5.BackColor = f5;
            pictureBox_f6.BackColor = f6;
            pictureBox_f7.BackColor = f7;
            pictureBox_f8.BackColor = f8;
            //F Stage

            //G Stage
            pictureBox_g1.BackColor = g1;
            pictureBox_g2.BackColor = g2;
            pictureBox_g3.BackColor = g3;
            pictureBox_g4.BackColor = g4;
            pictureBox_g5.BackColor = g5;
            pictureBox_g6.BackColor = g6;
            pictureBox_g7.BackColor = g7;
            pictureBox_g8.BackColor = g8;
            //G Stage

            //H Stage
            pictureBox_h1.BackColor = h1;
            pictureBox_h2.BackColor = h2;
            pictureBox_h3.BackColor = h3;
            pictureBox_h4.BackColor = h4;
            pictureBox_h5.BackColor = h5;
            pictureBox_h6.BackColor = h6;
            pictureBox_h7.BackColor = h7;
            pictureBox_h8.BackColor = h8;
            //H Stage
       
        }
        //set all squares to default color

        //PCS Attack
        private void combat(PictureBox bpb, bool bpb_selected, PictureBox wpb, Point bpb_xy, Point wpb_xy)
        {
            
            if (bpb_selected == true)
            {
                if (colorcheck(wpb_xy) == true)
                {
                    resetsqrs();
                    clrselected();
                    clrtoogle();
                    bpb.Location = wpb_xy;
                    wpb.Location = new Point(Blackcaptured.X, 550);
                    Blackcaptured = new Point(Blackcaptured.X + 30, Blackcaptured.Y);
                    start();
                    Rotate();
                    blackturn = !blackturn;
                    whiteturn = !whiteturn;

                    /*bpb_xy = wpb_xy;
                    wpb_xy = new Point(0,0);*/
                }
            }
        }
        //PCS Attack

        //x sqr on standing a piece?
        private bool sqrcheck(Point xy)
        {
            bool sqrchecked = false;

            if (new Point(WhitePawn1_xy.X, WhitePawn1_xy.Y) == xy) { sqrchecked = true; }

            if (new Point(WhitePawn2_xy.X, WhitePawn2_xy.Y) == xy) { sqrchecked = true; }

            if (new Point(WhitePawn3_xy.X, WhitePawn3_xy.Y) == xy) { sqrchecked = true; }

            if (new Point(WhitePawn4_xy.X, WhitePawn4_xy.Y) == xy) { sqrchecked = true; }

            if (new Point(WhitePawn5_xy.X, WhitePawn5_xy.Y) == xy) { sqrchecked = true; }

            if (new Point(WhitePawn6_xy.X, WhitePawn6_xy.Y) == xy) { sqrchecked = true; }

            if (new Point(WhitePawn7_xy.X, WhitePawn7_xy.Y) == xy) { sqrchecked = true; }

            if (new Point(WhitePawn8_xy.X, WhitePawn8_xy.Y) == xy) { sqrchecked = true; }

            if (new Point(WhiteRook1_xy.X, WhiteRook1_xy.Y) == xy) { sqrchecked = true; }

            if (new Point(WhiteKnight1_xy.X, WhiteKnight1_xy.Y) == xy) { sqrchecked = true; }

            if (new Point(WhiteBishop1_xy.X, WhiteBishop1_xy.Y) == xy) { sqrchecked = true; }

            if (new Point(WhiteQueen_xy.X, WhiteQueen_xy.Y) == xy) { sqrchecked = true; }

            if (new Point(WhiteKing_xy.X, WhiteKing_xy.Y) == xy) { sqrchecked = true; }

            if (new Point(WhiteBishop2_xy.X, WhiteBishop2_xy.Y) == xy) { sqrchecked = true; }

            if (new Point(WhiteKnight2_xy.X, WhiteKnight2_xy.Y) == xy) { sqrchecked = true; }

            if (new Point(WhiteRook2_xy.X, WhiteRook2_xy.Y) == xy) { sqrchecked = true; }

            if (new Point(BlackPawn1_xy.X, BlackPawn1_xy.Y) == xy) { sqrchecked = true; }

            if (new Point(BlackPawn2_xy.X, BlackPawn2_xy.Y) == xy) { sqrchecked = true; }

            if (new Point(BlackPawn3_xy.X, BlackPawn3_xy.Y) == xy) { sqrchecked = true; }

            if (new Point(BlackPawn4_xy.X, BlackPawn4_xy.Y) == xy) { sqrchecked = true; }

            if (new Point(BlackPawn5_xy.X, BlackPawn5_xy.Y) == xy) { sqrchecked = true; }

            if (new Point(BlackPawn6_xy.X, BlackPawn6_xy.Y) == xy) { sqrchecked = true; }

            if (new Point(BlackPawn7_xy.X, BlackPawn7_xy.Y) == xy) { sqrchecked = true; }

            if (new Point(BlackPawn8_xy.X, BlackPawn8_xy.Y) == xy) { sqrchecked = true; }

            if (new Point(BlackRook1_xy.X, BlackRook1_xy.Y) == xy) { sqrchecked = true; }

            if (new Point(BlackKnight1_xy.X, BlackKnight1_xy.Y) == xy) { sqrchecked = true; }

            if (new Point(BlackBishop1_xy.X, BlackBishop1_xy.Y) == xy) { sqrchecked = true; }

            if (new Point(BlackQueen_xy.X, BlackQueen_xy.Y) == xy) { sqrchecked = true; }

            if (new Point(BlackKing_xy.X, BlackKing_xy.Y) == xy) { sqrchecked = true; }

            if (new Point(BlackBishop2_xy.X, BlackBishop2_xy.Y) == xy) { sqrchecked = true; }

            if (new Point(BlackKnight2_xy.X, BlackKnight2_xy.Y) == xy) { sqrchecked = true; }

            if (new Point(BlackRook2_xy.X, BlackRook2_xy.Y) == xy) { sqrchecked = true; }

            return sqrchecked;
        }

        private bool sqrcheck_black(Point xy)
        {
            bool sqrchecked = false;
            
            if (new Point(BlackPawn1_xy.X, BlackPawn1_xy.Y) == xy) { sqrchecked = true; }

            if (new Point(BlackPawn2_xy.X, BlackPawn2_xy.Y) == xy) { sqrchecked = true; }

            if (new Point(BlackPawn3_xy.X, BlackPawn3_xy.Y) == xy) { sqrchecked = true; }

            if (new Point(BlackPawn4_xy.X, BlackPawn4_xy.Y) == xy) { sqrchecked = true; }

            if (new Point(BlackPawn5_xy.X, BlackPawn5_xy.Y) == xy) { sqrchecked = true; }

            if (new Point(BlackPawn6_xy.X, BlackPawn6_xy.Y) == xy) { sqrchecked = true; }

            if (new Point(BlackPawn7_xy.X, BlackPawn7_xy.Y) == xy) { sqrchecked = true; }

            if (new Point(BlackPawn8_xy.X, BlackPawn8_xy.Y) == xy) { sqrchecked = true; }

            if (new Point(BlackRook1_xy.X, BlackRook1_xy.Y) == xy) { sqrchecked = true; }

            if (new Point(BlackKnight1_xy.X, BlackKnight1_xy.Y) == xy) { sqrchecked = true; }

            if (new Point(BlackBishop1_xy.X, BlackBishop1_xy.Y) == xy) { sqrchecked = true; }

            if (new Point(BlackQueen_xy.X, BlackQueen_xy.Y) == xy) { sqrchecked = true; }

            if (new Point(BlackKing_xy.X, BlackKing_xy.Y) == xy) { sqrchecked = true; }

            if (new Point(BlackBishop2_xy.X, BlackBishop2_xy.Y) == xy) { sqrchecked = true; }

            if (new Point(BlackKnight2_xy.X, BlackKnight2_xy.Y) == xy) { sqrchecked = true; }

            if (new Point(BlackRook2_xy.X, BlackRook2_xy.Y) == xy) { sqrchecked = true; }

            return sqrchecked;
        }

        private bool sqrcheck_white(Point xy)
        {
            bool sqrchecked = false;

            if (new Point(WhitePawn1_xy.X, WhitePawn1_xy.Y) == xy) { sqrchecked = true; }

            if (new Point(WhitePawn2_xy.X, WhitePawn2_xy.Y) == xy) { sqrchecked = true; }

            if (new Point(WhitePawn3_xy.X, WhitePawn3_xy.Y) == xy) { sqrchecked = true; }

            if (new Point(WhitePawn4_xy.X, WhitePawn4_xy.Y) == xy) { sqrchecked = true; }

            if (new Point(WhitePawn5_xy.X, WhitePawn5_xy.Y) == xy) { sqrchecked = true; }

            if (new Point(WhitePawn6_xy.X, WhitePawn6_xy.Y) == xy) { sqrchecked = true; }

            if (new Point(WhitePawn7_xy.X, WhitePawn7_xy.Y) == xy) { sqrchecked = true; }

            if (new Point(WhitePawn8_xy.X, WhitePawn8_xy.Y) == xy) { sqrchecked = true; }

            if (new Point(WhiteRook1_xy.X, WhiteRook1_xy.Y) == xy) { sqrchecked = true; }

            if (new Point(WhiteKnight1_xy.X, WhiteKnight1_xy.Y) == xy) { sqrchecked = true; }

            if (new Point(WhiteBishop1_xy.X, WhiteBishop1_xy.Y) == xy) { sqrchecked = true; }

            if (new Point(WhiteQueen_xy.X, WhiteQueen_xy.Y) == xy) { sqrchecked = true; }

            if (new Point(WhiteKing_xy.X, WhiteKing_xy.Y) == xy) { sqrchecked = true; }

            if (new Point(WhiteBishop2_xy.X, WhiteBishop2_xy.Y) == xy) { sqrchecked = true; }

            if (new Point(WhiteKnight2_xy.X, WhiteKnight2_xy.Y) == xy) { sqrchecked = true; }

            if (new Point(WhiteRook2_xy.X, WhiteRook2_xy.Y) == xy) { sqrchecked = true; }

            return sqrchecked;
        }

        //x sqr on standing a piece?

        //x Point turn to inverse
        private Point convsqr(Point x)
        {
            x = new Point(370 - x.X, 370 - x.Y);
            return x;
        }
        //x Point turn to inverse

        //x pb.location -> inverse pb.location
        private void conv(PictureBox black, PictureBox white)
            {
            Point temp;
            temp = black.Location;
            black.Location = white.Location;
            white.Location = temp;
            }
        //x pb.location -> inverse pb.location

        //Rotate the board
        private void Rotate()
        {
            
            //SQRS Rotate
            //a->h
            conv(pictureBox_a1, pictureBox_h8);
            conv(pictureBox_a2, pictureBox_h7);
            conv(pictureBox_a3, pictureBox_h6);
            conv(pictureBox_a4, pictureBox_h5);
            conv(pictureBox_a5, pictureBox_h4);
            conv(pictureBox_a6, pictureBox_h3);
            conv(pictureBox_a7, pictureBox_h2);
            conv(pictureBox_a8, pictureBox_h1);
            //b->g
            conv(pictureBox_b1, pictureBox_g8);
            conv(pictureBox_b2, pictureBox_g7);
            conv(pictureBox_b3, pictureBox_g6);
            conv(pictureBox_b4, pictureBox_g5);
            conv(pictureBox_b5, pictureBox_g4);
            conv(pictureBox_b6, pictureBox_g3);
            conv(pictureBox_b7, pictureBox_g2);
            conv(pictureBox_b8, pictureBox_g1);
            //c->f
            conv(pictureBox_c1, pictureBox_f8);
            conv(pictureBox_c2, pictureBox_f7);
            conv(pictureBox_c3, pictureBox_f6);
            conv(pictureBox_c4, pictureBox_f5);
            conv(pictureBox_c5, pictureBox_f4);
            conv(pictureBox_c6, pictureBox_f3);
            conv(pictureBox_c7, pictureBox_f2);
            conv(pictureBox_c8, pictureBox_f1);
            //d->e
            conv(pictureBox_d1, pictureBox_e8);
            conv(pictureBox_d2, pictureBox_e7);
            conv(pictureBox_d3, pictureBox_e6);
            conv(pictureBox_d4, pictureBox_e5);
            conv(pictureBox_d5, pictureBox_e4);
            conv(pictureBox_d6, pictureBox_e3);
            conv(pictureBox_d7, pictureBox_e2);
            conv(pictureBox_d8, pictureBox_e1);
            //SQRS Rotate

            //PCS Rotate
            pictureBox_blackpawn1.Location = convsqr(pictureBox_blackpawn1.Location);
            pictureBox_blackpawn2.Location = convsqr(pictureBox_blackpawn2.Location);
            pictureBox_blackpawn3.Location = convsqr(pictureBox_blackpawn3.Location);
            pictureBox_blackpawn4.Location = convsqr(pictureBox_blackpawn4.Location);
            pictureBox_blackpawn5.Location = convsqr(pictureBox_blackpawn5.Location);
            pictureBox_blackpawn6.Location = convsqr(pictureBox_blackpawn6.Location);
            pictureBox_blackpawn7.Location = convsqr(pictureBox_blackpawn7.Location);
            pictureBox_blackpawn8.Location = convsqr(pictureBox_blackpawn8.Location);
            pictureBox_blackrook1.Location = convsqr(pictureBox_blackrook1.Location);
            pictureBox_blackknight1.Location = convsqr(pictureBox_blackknight1.Location);
            pictureBox_blackbishop1.Location = convsqr(pictureBox_blackbishop1.Location);
            pictureBox_blackqueen.Location = convsqr(pictureBox_blackqueen.Location);
            pictureBox_blackking.Location = convsqr(pictureBox_blackking.Location);
            pictureBox_blackbishop2.Location = convsqr(pictureBox_blackbishop2.Location);
            pictureBox_blackknight2.Location = convsqr(pictureBox_blackknight2.Location);
            pictureBox_blackrook2.Location = convsqr(pictureBox_blackrook2.Location);

            pictureBox_whitepawn1.Location = convsqr(pictureBox_whitepawn1.Location);
            pictureBox_whitepawn2.Location = convsqr(pictureBox_whitepawn2.Location);
            pictureBox_whitepawn3.Location = convsqr(pictureBox_whitepawn3.Location);
            pictureBox_whitepawn4.Location = convsqr(pictureBox_whitepawn4.Location);
            pictureBox_whitepawn5.Location = convsqr(pictureBox_whitepawn5.Location);
            pictureBox_whitepawn6.Location = convsqr(pictureBox_whitepawn6.Location);
            pictureBox_whitepawn7.Location = convsqr(pictureBox_whitepawn7.Location);
            pictureBox_whitepawn8.Location = convsqr(pictureBox_whitepawn8.Location);
            pictureBox_whiterook1.Location = convsqr(pictureBox_whiterook1.Location);
            pictureBox_whiteknight1.Location = convsqr(pictureBox_whiteknight1.Location);
            pictureBox_whitebishop1.Location = convsqr(pictureBox_whitebishop1.Location);
            pictureBox_whitequeen.Location = convsqr(pictureBox_whitequeen.Location);
            pictureBox_whiteking.Location = convsqr(pictureBox_whiteking.Location);
            pictureBox_whitebishop2.Location = convsqr(pictureBox_whitebishop2.Location);
            pictureBox_whiteknight2.Location = convsqr(pictureBox_whiteknight2.Location);
            pictureBox_whiterook2.Location = convsqr(pictureBox_whiterook2.Location);
            //PCS Rotate

            //SQRS Point variable Rotate
            //a
            a1c = convsqr(a1c);
            a2c = convsqr(a2c);
            a3c = convsqr(a3c);
            a4c = convsqr(a4c);
            a5c = convsqr(a5c);
            a6c = convsqr(a6c);
            a7c = convsqr(a7c);
            a8c = convsqr(a8c);
            //b
            b1c = convsqr(b1c);
            b2c = convsqr(b2c);
            b3c = convsqr(b3c);
            b4c = convsqr(b4c);
            b5c = convsqr(b5c);
            b6c = convsqr(b6c);
            b7c = convsqr(b7c);
            b8c = convsqr(b8c);
            //c
            c1c = convsqr(c1c);
            c2c = convsqr(c2c);
            c3c = convsqr(c3c);
            c4c = convsqr(c4c);
            c5c = convsqr(c5c);
            c6c = convsqr(c6c);
            c7c = convsqr(c7c);
            c8c = convsqr(c8c);
            //d
            d1c = convsqr(d1c);
            d2c = convsqr(d2c);
            d3c = convsqr(d3c);
            d4c = convsqr(d4c);
            d5c = convsqr(d5c);
            d6c = convsqr(d6c);
            d7c = convsqr(d7c);
            d8c = convsqr(d8c);
            //e
            e1c = convsqr(e1c);
            e2c = convsqr(e2c);
            e3c = convsqr(e3c);
            e4c = convsqr(e4c);
            e5c = convsqr(e5c);
            e6c = convsqr(e6c);
            e7c = convsqr(e7c);
            e8c = convsqr(e8c);

            f1c = convsqr(f1c);
            f2c = convsqr(f2c);
            f3c = convsqr(f3c);
            f4c = convsqr(f4c);
            f5c = convsqr(f5c);
            f6c = convsqr(f6c);
            f7c = convsqr(f7c);
            f8c = convsqr(f8c);

            g1c = convsqr(g1c);
            g2c = convsqr(g2c);
            g3c = convsqr(g3c);
            g4c = convsqr(g4c);
            g5c = convsqr(g5c);
            g6c = convsqr(g6c);
            g7c = convsqr(g7c);
            g8c = convsqr(g8c);

            h1c = convsqr(h1c);
            h2c = convsqr(h2c);
            h3c = convsqr(h3c);
            h4c = convsqr(h4c);
            h5c = convsqr(h5c);
            h6c = convsqr(h6c);
            h7c = convsqr(h7c);
            h8c = convsqr(h8c);

            //BLCKPCS
            //BLCKPWNS
            BlackPawn1_xy = convsqr(BlackPawn1_xy);
            BlackPawn2_xy = convsqr(BlackPawn2_xy);
            BlackPawn3_xy = convsqr(BlackPawn3_xy);
            BlackPawn4_xy = convsqr(BlackPawn4_xy);
            BlackPawn5_xy = convsqr(BlackPawn5_xy);
            BlackPawn6_xy = convsqr(BlackPawn6_xy);
            BlackPawn7_xy = convsqr(BlackPawn7_xy);
            BlackPawn8_xy = convsqr(BlackPawn8_xy);
            //BLCKPWNS

            BlackRook1_xy = convsqr(BlackRook1_xy);
            BlackKnight1_xy = convsqr(BlackKnight1_xy);
            BlackBishop1_xy = convsqr(BlackBishop1_xy);
            BlackQueen_xy = convsqr(BlackQueen_xy);
            BlackKing_xy = convsqr(BlackKing_xy);
            BlackBishop2_xy = convsqr(BlackBishop2_xy);
            BlackKnight2_xy = convsqr(BlackKnight2_xy);
            BlackRook2_xy = convsqr(BlackRook2_xy);
            //BLCKPCS

            //WHTPCS
            //WHTPWNS
            WhitePawn1_xy = convsqr(WhitePawn1_xy);
            WhitePawn2_xy = convsqr(WhitePawn2_xy);
            WhitePawn3_xy = convsqr(WhitePawn3_xy);
            WhitePawn4_xy = convsqr(WhitePawn4_xy);
            WhitePawn5_xy = convsqr(WhitePawn5_xy);
            WhitePawn6_xy = convsqr(WhitePawn6_xy);
            WhitePawn7_xy = convsqr(WhitePawn7_xy);
            WhitePawn8_xy = convsqr(WhitePawn8_xy);
            //WHTPWNS

            WhiteRook1_xy = convsqr(WhiteRook1_xy);
            WhiteKnight1_xy = convsqr(WhiteKnight1_xy);
            WhiteBishop1_xy = convsqr(WhiteBishop1_xy);
            WhiteQueen_xy = convsqr(WhiteQueen_xy);
            WhiteKing_xy = convsqr(WhiteKing_xy);
            WhiteBishop2_xy = convsqr(WhiteBishop2_xy);
            WhiteKnight2_xy = convsqr(WhiteKnight2_xy);
            WhiteRook2_xy = convsqr(WhiteRook2_xy);
            //WHTPCS

        }
        //Rotate the board

        //Click actions

        private void button_start_Click(object sender, EventArgs e)
        {
            start();
        }
        //BLCKPCS
        //BLCKPWNS

        private void pictureBox_blackpawn1_Click(object sender, EventArgs e)
        {
            combatmix(pictureBox_blackpawn1, BlackPawn1_xy);

            if (blackturn == true)
            {
                if (BlackPawn1_toggle == false)
                {
                    clrtoogle();
                    resetsqrs();
                    clrselected();
                    BlackPawn1_toggle = true;
                    BlackPawn1_selected = true;

                    pawnmove(BlackPawn1_xy, "b", b1c);
                }
                else
                {
                    BlackPawn1_toggle = false; BlackPawn1_selected = false; resetsqrs();
                }
            }
        }
                
        private void pictureBox_blackpawn2_Click(object sender, EventArgs e)
        {
            combatmix(pictureBox_blackpawn2, BlackPawn2_xy);

            if (blackturn == true)
            {if (BlackPawn2_toggle == false)
            {
                clrselected();
                clrtoogle();
                resetsqrs();
                BlackPawn2_toggle = true;
                BlackPawn2_selected = true;

                pawnmove(BlackPawn2_xy, "b", b2c);
            }
            else { BlackPawn2_toggle = false; BlackPawn2_selected = false; resetsqrs(); }

            }
            
        }

        private void pictureBox_blackpawn3_Click(object sender, EventArgs e)
        {
            combatmix(pictureBox_blackpawn3, BlackPawn3_xy);

            if (blackturn == true)
            {if (BlackPawn3_toggle == false)
            {
                clrselected();
                clrtoogle();
                resetsqrs();
                BlackPawn3_toggle = true;
                BlackPawn3_selected = true;

                pawnmove(BlackPawn3_xy, "b", b3c);
            }
            else { BlackPawn3_toggle = false; BlackPawn3_selected = false; resetsqrs(); }

            }
            
        }

        private void pictureBox_blackpawn4_Click(object sender, EventArgs e)
        {
            combatmix(pictureBox_blackpawn4, BlackPawn4_xy);

            if (blackturn == true)
            {if (BlackPawn4_toggle == false)
            {
                clrselected();
                clrtoogle();
                resetsqrs();
                BlackPawn4_toggle = true;
                BlackPawn4_selected = true;

                pawnmove(BlackPawn4_xy, "b", b4c);
            }
            else { BlackPawn4_toggle = false; BlackPawn4_selected = false; resetsqrs(); }

            }
            
        }

        private void pictureBox_blackpawn5_Click(object sender, EventArgs e)
        {
            combatmix(pictureBox_blackpawn5, BlackPawn5_xy);

            if (blackturn == true)
            { if (BlackPawn5_toggle == false)
            {
                clrselected();
                clrtoogle();
                resetsqrs();
                BlackPawn5_toggle = true;
                BlackPawn5_selected = true;

                pawnmove(BlackPawn5_xy, "b", b5c);
            }
            else { BlackPawn5_toggle = false; BlackPawn5_selected = false; resetsqrs(); }

            }
           
        }

        private void pictureBox_blackpawn6_Click(object sender, EventArgs e)
        {
            combatmix(pictureBox_blackpawn6, BlackPawn6_xy);

            if (blackturn == true)
            { if (BlackPawn6_toggle == false)
            {
                clrselected();
                clrtoogle();
                resetsqrs();
                BlackPawn6_toggle = true;
                BlackPawn6_selected = true;

                pawnmove(BlackPawn6_xy, "b", b6c);
            }
            else { BlackPawn6_toggle = false; BlackPawn6_selected = false; resetsqrs(); }

            }
           
        }

        private void pictureBox_blackpawn7_Click(object sender, EventArgs e)
        {
            combatmix(pictureBox_blackpawn7, BlackPawn7_xy);

            if (blackturn == true)
            { if (BlackPawn7_toggle == false)
            {
                clrselected();
                clrtoogle();
                resetsqrs();
                BlackPawn7_toggle = true;
                BlackPawn7_selected = true;

                pawnmove(BlackPawn7_xy, "b", b7c);
            }
            else { BlackPawn7_toggle = false; BlackPawn7_selected = false; resetsqrs(); }

            }
           
        }

        private void pictureBox_blackpawn8_Click(object sender, EventArgs e)
        {
            combatmix(pictureBox_blackpawn8, BlackPawn8_xy);

            if (blackturn == true)
            {if (BlackPawn8_toggle == false)
            {
                clrselected();
                clrtoogle();
                resetsqrs();
                BlackPawn8_toggle = true;
                BlackPawn8_selected = true;

                pawnmove(BlackPawn8_xy, "b", b8c);
            }
            else { BlackPawn8_toggle = false; BlackPawn8_selected = false; resetsqrs(); }
        }

            }
            

        //BLCKPWNS
        private void pictureBox_blackrook1_Click(object sender, EventArgs e)
        {
            combatmix(pictureBox_blackrook1, BlackRook1_xy);

            if (blackturn == true)
            {if (BlackRook1_toggle == false)
            {
                clrselected();
                clrtoogle();
                resetsqrs();
                BlackRook1_toggle = true;
                BlackRook1_selected = true;

                rookmove(BlackRook1_xy, "b");

            }
            else { BlackRook1_toggle = false; BlackRook1_selected = false; resetsqrs(); }

            }
            
        }

        private void pictureBox_blackknight1_Click(object sender, EventArgs e)
        {
            combatmix(pictureBox_blackknight1, BlackKnight1_xy);

            if (blackturn == true)
            {  if (BlackKnight1_toggle == false)
            {
                clrselected();
                clrtoogle();
                resetsqrs();
                BlackKnight1_toggle = true;
                BlackKnight1_selected = true;

                knightmove(BlackKnight1_xy, "b");

            }
            else { BlackKnight1_toggle = false; BlackKnight1_selected = false; resetsqrs(); }

            }
        }

        private void pictureBox_blackbishop1_Click(object sender, EventArgs e)
        {
            combatmix(pictureBox_blackbishop1, BlackBishop1_xy);

            if (blackturn == true)
            {if (BlackBishop1_toggle == false)
            {
                clrselected();
                clrtoogle();
                resetsqrs();
                BlackBishop1_toggle = true;
                BlackBishop1_selected = true;

                bishopmove(BlackBishop1_xy, "b");

            }
            else
            { BlackBishop1_toggle = false; BlackBishop1_selected = false; resetsqrs(); }

            }
        }

        private void pictureBox_blackqueen_Click(object sender, EventArgs e)
        {
            combatmix(pictureBox_blackqueen, BlackQueen_xy);

            if (blackturn == true)
            {if (BlackQueen_toggle == false)
                {
                    clrselected();
                    clrtoogle();
                    resetsqrs();
                    BlackQueen_toggle = true;
                    BlackQueen_selected = true;

                    queenmove(BlackQueen_xy, "b");
                }
                else
                { BlackQueen_toggle = false; BlackQueen_selected = false; resetsqrs(); }
                   
            }
        }

        private void pictureBox_blackking_Click(object sender, EventArgs e)
        {
            combatmix(pictureBox_blackking, BlackKing_xy);

            if (blackturn == true)
            {if (BlackKing_toggle == false)
            {
                clrselected();
                clrtoogle();
                resetsqrs();
                BlackKing_toggle = true;
                BlackKing_selected = true;

                kingmove(BlackKing_xy, "b");

            }
            else
            { BlackKing_toggle = false; BlackKing_selected = false; resetsqrs(); }

            }   
        }

        private void pictureBox_blackbishop2_Click(object sender, EventArgs e)
        {
            combatmix(pictureBox_blackbishop2, BlackBishop2_xy);

            if (blackturn == true)
            {
                if (BlackBishop2_toggle == false)
                {
                    clrselected();
                    clrtoogle();
                    resetsqrs();
                    BlackBishop2_toggle = true;
                    BlackBishop2_selected = true;

                    bishopmove(BlackBishop2_xy, "b");

                }
                else
                { BlackBishop2_toggle = false; BlackBishop2_selected = false; resetsqrs(); }

            }
        }

        private void pictureBox_blackknight2_Click(object sender, EventArgs e)
        {
            combatmix(pictureBox_blackknight2, BlackKnight2_xy);

            if (blackturn == true)
            {if (BlackKnight2_toggle == false)
            {
                clrselected();
                clrtoogle();
                resetsqrs();
                BlackKnight2_toggle = true;
                BlackKnight2_selected = true;

                knightmove(BlackKnight2_xy, "b");

            }
            else { BlackKnight2_toggle = false; BlackKnight2_selected = false; resetsqrs(); }

            }
        }

        private void pictureBox_blackrook2_Click(object sender, EventArgs e)
        {
            combatmix(pictureBox_blackrook2, BlackRook2_xy);

            if (blackturn == true)
            { if (BlackRook2_toggle == false)
            {
                clrselected();
                clrtoogle();
                resetsqrs();
                BlackRook2_toggle = true;
                BlackRook2_selected = true;

                rookmove(BlackRook2_xy, "b");

            }
            else { BlackRook2_toggle = false; BlackRook2_selected = false; resetsqrs(); }
            }
        }
        //BLCKPCS

        //WHTPCS
        //WHTPWNS
        private void pictureBox_whitepawn1_Click(object sender, EventArgs e)
        {
            combatmix(pictureBox_whitepawn1,WhitePawn1_xy);
            

            if (whiteturn == true)
            {if (WhitePawn1_toggle == false)
            {
                clrselected();
                clrtoogle();
                resetsqrs();
                WhitePawn1_toggle = true;
                WhitePawn1_selected = true;

                pawnmove(WhitePawn1_xy, "w", g1c);
            }
            else { WhitePawn1_toggle = false; WhitePawn1_selected = false; resetsqrs(); }

            }
            
        }

        private void pictureBox_whitepawn2_Click(object sender, EventArgs e)
        {
            combatmix(pictureBox_whitepawn2, WhitePawn2_xy);

            if (whiteturn == true)
            {if (WhitePawn2_toggle == false)
            {
                clrselected();
                clrtoogle();
                resetsqrs();
                WhitePawn2_toggle = true;
                WhitePawn2_selected = true;

                pawnmove(WhitePawn2_xy, "w", g2c);
            }
            else { WhitePawn2_toggle = false; WhitePawn2_selected = false; resetsqrs(); }

            }
            
        }

        private void pictureBox_whitepawn3_Click(object sender, EventArgs e)
        {
            combatmix(pictureBox_whitepawn3, WhitePawn3_xy);

            if (whiteturn == true)
            { if (WhitePawn3_toggle == false)
            {
                clrselected();
                clrtoogle();
                resetsqrs();
                WhitePawn3_toggle = true;
                WhitePawn3_selected = true;

                pawnmove(WhitePawn3_xy, "w", g3c);
            }
            else { WhitePawn3_toggle = false; WhitePawn3_selected = false; resetsqrs(); }

            }
           
        }

        private void pictureBox_whitepawn4_Click(object sender, EventArgs e)
        {
            combatmix(pictureBox_whitepawn4, WhitePawn4_xy);

            if (whiteturn == true)
            {if (WhitePawn4_toggle == false)
            {
                clrselected();
                clrtoogle();
                resetsqrs();
                WhitePawn4_toggle = true;
                WhitePawn4_selected = true;

                pawnmove(WhitePawn4_xy, "w", g4c);
            }
            else { WhitePawn4_toggle = false; WhitePawn4_selected = false; resetsqrs(); }

            }
            
        }

        private void pictureBox_whitepawn5_Click(object sender, EventArgs e)
        {
            combatmix(pictureBox_whitepawn5, WhitePawn5_xy);

            if (whiteturn == true)
            {if (WhitePawn5_toggle == false)
            {
                clrselected();
                clrtoogle();
                resetsqrs();
                WhitePawn5_toggle = true;
                WhitePawn5_selected = true;

                pawnmove(WhitePawn5_xy, "w", g5c);
            }
            else { WhitePawn5_toggle = false; WhitePawn5_selected = false; resetsqrs(); }

            }
            
        }

        private void pictureBox_whitepawn6_Click(object sender, EventArgs e)
        {
            combatmix(pictureBox_whitepawn6, WhitePawn6_xy);

            if (whiteturn == true)
            {if (WhitePawn6_toggle == false)
            {
                clrselected();
                clrtoogle();
                resetsqrs();
                WhitePawn6_toggle = true;
                WhitePawn6_selected = true;

                pawnmove(WhitePawn6_xy, "w", g6c);
            }
            else { WhitePawn6_toggle = false; WhitePawn6_selected = false; resetsqrs(); }

            }
            
        }

        private void pictureBox_whitepawn7_Click(object sender, EventArgs e)
        {
            combatmix(pictureBox_whitepawn7, WhitePawn7_xy);

            if (whiteturn == true)
            {if (WhitePawn7_toggle == false)
            {
                clrselected();
                clrtoogle();
                resetsqrs();
                WhitePawn7_toggle = true;
                WhitePawn7_selected = true;

                pawnmove(WhitePawn7_xy, "w", g7c);
            }
            else { WhitePawn7_toggle = false; WhitePawn7_selected = false; resetsqrs(); }

            }
            
        }

        private void pictureBox_whitepawn8_Click(object sender, EventArgs e)
        {
            combatmix(pictureBox_whitepawn8, WhitePawn8_xy);

            if (whiteturn == true)
            { if (WhitePawn8_toggle == false)
            {
                clrselected();
                clrtoogle();
                resetsqrs();
                WhitePawn8_toggle = true;
                WhitePawn8_selected = true;

                pawnmove(WhitePawn8_xy, "w", g8c);
            }
            else { WhitePawn8_toggle = false; WhitePawn8_selected = false; resetsqrs(); }

            }
           
        }
        //WHTPWNS
 
        private void pictureBox_whiterook1_Click(object sender, EventArgs e)
        {
            combatmix(pictureBox_whiterook1, WhiteRook1_xy);

            if (whiteturn == true)
            {if (WhiteRook1_toggle == false)
            {
                clrselected();
                clrtoogle();
                resetsqrs();
                WhiteRook1_toggle = true;
                WhiteRook1_selected = true;

                rookmove(WhiteRook1_xy, "w");

            }
            else { WhiteRook1_toggle = false; WhiteRook1_selected = false; resetsqrs(); }

            }
            
        }

        private void pictureBox_whiteknight1_Click(object sender, EventArgs e)
        {
            combatmix(pictureBox_whiteknight1, WhiteKnight1_xy);

            if (whiteturn == true)
            {if (WhiteKnight1_toggle == false)
            {
                clrselected();
                clrtoogle();
                resetsqrs();
                WhiteKnight1_toggle = true;
                WhiteKnight1_selected = true;

                knightmove(WhiteKnight1_xy, "w");

            }
            else { WhiteKnight1_toggle = false; WhiteKnight1_selected = false; resetsqrs(); }

            }
            
        }

        private void pictureBox_whitebishop1_Click(object sender, EventArgs e)
        {
            combatmix(pictureBox_whitebishop1, WhiteBishop1_xy);

            if (whiteturn == true)
            {
                if (WhiteBishop1_toggle == false)
                {
                    clrselected();
                    clrtoogle();
                    resetsqrs();
                    WhiteBishop1_toggle = true;
                    WhiteBishop1_selected = true;

                    bishopmove(WhiteBishop1_xy, "w");

                }
                else
                { WhiteBishop1_toggle = false; WhiteBishop1_selected = false; resetsqrs(); }

            }
        }

        private void pictureBox_whitequeen_Click(object sender, EventArgs e)
        {
            combatmix(pictureBox_whitequeen, WhiteQueen_xy);

            if (whiteturn == true)
            {
                if (WhiteQueen_toggle == false)
                {
                    clrselected();
                    clrtoogle();
                    resetsqrs();
                    WhiteQueen_toggle = true;
                    WhiteQueen_selected = true;

                    queenmove(WhiteQueen_xy, "w");
                }
                else
                { WhiteQueen_toggle = false; WhiteQueen_selected = false; resetsqrs(); }

            }
        }

        private void pictureBox_whiteking_Click(object sender, EventArgs e)
        {
            combatmix(pictureBox_whiteking, WhiteKing_xy);

            if (whiteturn == true)
            { if (WhiteKing_toggle == false)
            {
                clrselected();
                clrtoogle();
                resetsqrs();
                WhiteKing_toggle = true;
                WhiteKing_selected = true;

                kingmove(WhiteKing_xy, "w");

            }
            else
            { WhiteKing_toggle = false; WhiteKing_selected = false; resetsqrs(); }

            }
           
            
        }

        private void pictureBox_whitebishop2_Click(object sender, EventArgs e)
        {
            combatmix(pictureBox_whitebishop2, WhiteBishop2_xy);

            if (whiteturn == true)
            {
                if (WhiteBishop2_toggle == false)
                {
                    clrselected();
                    clrtoogle();
                    resetsqrs();
                    WhiteBishop2_toggle = true;
                    WhiteBishop2_selected = true;

                    bishopmove(WhiteBishop2_xy, "w");

                }
                else
                { WhiteBishop2_toggle = false; WhiteBishop2_selected = false; resetsqrs(); }

            }
        }

        private void pictureBox_whiteknight2_Click(object sender, EventArgs e)
        {
            combatmix(pictureBox_whiteknight2, WhiteKnight2_xy);

            if (whiteturn == true)
            {if (WhiteKnight2_toggle == false)
            {
                clrselected();
                clrtoogle();
                resetsqrs();
                WhiteKnight2_toggle = true;
                WhiteKnight2_selected = true;

                knightmove(WhiteKnight2_xy, "w");

            }
            else { WhiteKnight2_toggle = false; WhiteKnight2_selected = false; resetsqrs(); }
        }

            }

        private void pictureBox_whiterook2_Click(object sender, EventArgs e)
        {
            combatmix(pictureBox_whiterook2, WhiteRook1_xy);

            if (whiteturn == true)
            {
                if (WhiteRook2_toggle == false)
                {
                    clrselected();
                    clrtoogle();
                    resetsqrs();
                    WhiteRook2_toggle = true;
                    WhiteRook2_selected = true;

                    rookmove(WhiteRook2_xy, "w");

                }
                else { WhiteRook2_toggle = false; WhiteRook2_selected = false; resetsqrs(); }
            }
        }
            
        //WHTPCS

        //SQRS


        private void pictureBox_a1_Click(object sender, EventArgs e)

        {
            move(pictureBox_blackpawn1, BlackPawn1_selected, BlackPawn1_xy, a1c);
            move(pictureBox_blackpawn2, BlackPawn2_selected, BlackPawn2_xy, a1c);
            move(pictureBox_blackpawn3, BlackPawn3_selected, BlackPawn3_xy, a1c);
            move(pictureBox_blackpawn4, BlackPawn4_selected, BlackPawn4_xy, a1c);
            move(pictureBox_blackpawn5, BlackPawn5_selected, BlackPawn5_xy, a1c);
            move(pictureBox_blackpawn6, BlackPawn6_selected, BlackPawn6_xy, a1c);
            move(pictureBox_blackpawn7, BlackPawn7_selected, BlackPawn7_xy, a1c);
            move(pictureBox_blackpawn8, BlackPawn8_selected, BlackPawn8_xy, a1c);
            move(pictureBox_blackrook1, BlackRook1_selected, BlackRook1_xy, a1c);
            move(pictureBox_blackknight1, BlackKnight1_selected, BlackKnight1_xy, a1c);
            move(pictureBox_blackbishop1, BlackBishop1_selected, BlackBishop1_xy, a1c);
            move(pictureBox_blackqueen, BlackQueen_selected, BlackQueen_xy, a1c);
            move(pictureBox_blackking, BlackKing_selected, BlackKing_xy, a1c);
            move(pictureBox_blackbishop2, BlackBishop2_selected, BlackBishop2_xy, a1c);
            move(pictureBox_blackknight2, BlackKnight2_selected, BlackKnight2_xy, a1c);
            move(pictureBox_blackrook2, BlackRook2_selected, BlackRook2_xy, a1c);

            move(pictureBox_whitepawn1, WhitePawn1_selected, WhitePawn1_xy, a1c);
            move(pictureBox_whitepawn2, WhitePawn2_selected, WhitePawn2_xy, a1c);
            move(pictureBox_whitepawn3, WhitePawn3_selected, WhitePawn3_xy, a1c);
            move(pictureBox_whitepawn4, WhitePawn4_selected, WhitePawn4_xy, a1c);
            move(pictureBox_whitepawn5, WhitePawn5_selected, WhitePawn5_xy, a1c);
            move(pictureBox_whitepawn6, WhitePawn6_selected, WhitePawn6_xy, a1c);
            move(pictureBox_whitepawn7, WhitePawn7_selected, WhitePawn7_xy, a1c);
            move(pictureBox_whitepawn8, WhitePawn8_selected, WhitePawn8_xy, a1c);
            move(pictureBox_whiterook1, WhiteRook1_selected, WhiteRook1_xy, a1c);
            move(pictureBox_whiteknight1, WhiteKnight1_selected, WhiteKnight1_xy, a1c);
            move(pictureBox_whitebishop1, WhiteBishop1_selected, WhiteBishop1_xy, a1c);
            move(pictureBox_whitequeen, WhiteQueen_selected, WhiteQueen_xy, a1c);
            move(pictureBox_whiteking, WhiteKing_selected, WhiteKing_xy, a1c);
            move(pictureBox_whitebishop2, WhiteBishop2_selected, WhiteBishop2_xy, a1c);
            move(pictureBox_whiteknight2, WhiteKnight2_selected, WhiteKnight2_xy, a1c);
            move(pictureBox_whiterook2, WhiteRook2_selected, WhiteRook2_xy, a1c);
        }

        private void pictureBox_a2_Click(object sender, EventArgs e)

        {
            move(pictureBox_blackpawn1, BlackPawn1_selected, BlackPawn1_xy, a2c);
            move(pictureBox_blackpawn2, BlackPawn2_selected, BlackPawn2_xy, a2c);
            move(pictureBox_blackpawn3, BlackPawn3_selected, BlackPawn3_xy, a2c);
            move(pictureBox_blackpawn4, BlackPawn4_selected, BlackPawn4_xy, a2c);
            move(pictureBox_blackpawn5, BlackPawn5_selected, BlackPawn5_xy, a2c);
            move(pictureBox_blackpawn6, BlackPawn6_selected, BlackPawn6_xy, a2c);
            move(pictureBox_blackpawn7, BlackPawn7_selected, BlackPawn7_xy, a2c);
            move(pictureBox_blackpawn8, BlackPawn8_selected, BlackPawn8_xy, a2c);
            move(pictureBox_blackrook1, BlackRook1_selected, BlackRook1_xy, a2c);
            move(pictureBox_blackknight1, BlackKnight1_selected, BlackKnight1_xy, a2c);
            move(pictureBox_blackbishop1, BlackBishop1_selected, BlackBishop1_xy, a2c);
            move(pictureBox_blackqueen, BlackQueen_selected, BlackQueen_xy, a2c);
            move(pictureBox_blackking, BlackKing_selected, BlackKing_xy, a2c);
            move(pictureBox_blackbishop2, BlackBishop2_selected, BlackBishop2_xy, a2c);
            move(pictureBox_blackknight2, BlackKnight2_selected, BlackKnight2_xy, a2c);
            move(pictureBox_blackrook2, BlackRook2_selected, BlackRook2_xy, a2c);

            move(pictureBox_whitepawn1, WhitePawn1_selected, WhitePawn1_xy, a2c);
            move(pictureBox_whitepawn2, WhitePawn2_selected, WhitePawn2_xy, a2c);
            move(pictureBox_whitepawn3, WhitePawn3_selected, WhitePawn3_xy, a2c);
            move(pictureBox_whitepawn4, WhitePawn4_selected, WhitePawn4_xy, a2c);
            move(pictureBox_whitepawn5, WhitePawn5_selected, WhitePawn5_xy, a2c);
            move(pictureBox_whitepawn6, WhitePawn6_selected, WhitePawn6_xy, a2c);
            move(pictureBox_whitepawn7, WhitePawn7_selected, WhitePawn7_xy, a2c);
            move(pictureBox_whitepawn8, WhitePawn8_selected, WhitePawn8_xy, a2c);
            move(pictureBox_whiterook1, WhiteRook1_selected, WhiteRook1_xy, a2c);
            move(pictureBox_whiteknight1, WhiteKnight1_selected, WhiteKnight1_xy, a2c);
            move(pictureBox_whitebishop1, WhiteBishop1_selected, WhiteBishop1_xy, a2c);
            move(pictureBox_whitequeen, WhiteQueen_selected, WhiteQueen_xy, a2c);
            move(pictureBox_whiteking, WhiteKing_selected, WhiteKing_xy, a2c);
            move(pictureBox_whitebishop2, WhiteBishop2_selected, WhiteBishop2_xy, a2c);
            move(pictureBox_whiteknight2, WhiteKnight2_selected, WhiteKnight2_xy, a2c);
            move(pictureBox_whiterook2, WhiteRook2_selected, WhiteRook2_xy, a2c);
        }

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void pictureBox_a3_Click(object sender, EventArgs e)

        {
            move(pictureBox_blackpawn1, BlackPawn1_selected, BlackPawn1_xy, a3c);
            move(pictureBox_blackpawn2, BlackPawn2_selected, BlackPawn2_xy, a3c);
            move(pictureBox_blackpawn3, BlackPawn3_selected, BlackPawn3_xy, a3c);
            move(pictureBox_blackpawn4, BlackPawn4_selected, BlackPawn4_xy, a3c);
            move(pictureBox_blackpawn5, BlackPawn5_selected, BlackPawn5_xy, a3c);
            move(pictureBox_blackpawn6, BlackPawn6_selected, BlackPawn6_xy, a3c);
            move(pictureBox_blackpawn7, BlackPawn7_selected, BlackPawn7_xy, a3c);
            move(pictureBox_blackpawn8, BlackPawn8_selected, BlackPawn8_xy, a3c);
            move(pictureBox_blackrook1, BlackRook1_selected, BlackRook1_xy, a3c);
            move(pictureBox_blackknight1, BlackKnight1_selected, BlackKnight1_xy, a3c);
            move(pictureBox_blackbishop1, BlackBishop1_selected, BlackBishop1_xy, a3c);
            move(pictureBox_blackqueen, BlackQueen_selected, BlackQueen_xy, a3c);
            move(pictureBox_blackking, BlackKing_selected, BlackKing_xy, a3c);
            move(pictureBox_blackbishop2, BlackBishop2_selected, BlackBishop2_xy, a3c);
            move(pictureBox_blackknight2, BlackKnight2_selected, BlackKnight2_xy, a3c);
            move(pictureBox_blackrook2, BlackRook2_selected, BlackRook2_xy, a3c);

            move(pictureBox_whitepawn1, WhitePawn1_selected, WhitePawn1_xy, a3c);
            move(pictureBox_whitepawn2, WhitePawn2_selected, WhitePawn2_xy, a3c);
            move(pictureBox_whitepawn3, WhitePawn3_selected, WhitePawn3_xy, a3c);
            move(pictureBox_whitepawn4, WhitePawn4_selected, WhitePawn4_xy, a3c);
            move(pictureBox_whitepawn5, WhitePawn5_selected, WhitePawn5_xy, a3c);
            move(pictureBox_whitepawn6, WhitePawn6_selected, WhitePawn6_xy, a3c);
            move(pictureBox_whitepawn7, WhitePawn7_selected, WhitePawn7_xy, a3c);
            move(pictureBox_whitepawn8, WhitePawn8_selected, WhitePawn8_xy, a3c);
            move(pictureBox_whiterook1, WhiteRook1_selected, WhiteRook1_xy, a3c);
            move(pictureBox_whiteknight1, WhiteKnight1_selected, WhiteKnight1_xy, a3c);
            move(pictureBox_whitebishop1, WhiteBishop1_selected, WhiteBishop1_xy, a3c);
            move(pictureBox_whitequeen, WhiteQueen_selected, WhiteQueen_xy, a3c);
            move(pictureBox_whiteking, WhiteKing_selected, WhiteKing_xy, a3c);
            move(pictureBox_whitebishop2, WhiteBishop2_selected, WhiteBishop2_xy, a3c);
            move(pictureBox_whiteknight2, WhiteKnight2_selected, WhiteKnight2_xy, a3c);
            move(pictureBox_whiterook2, WhiteRook2_selected, WhiteRook2_xy, a3c);
        }

        private void pictureBox_a4_Click(object sender, EventArgs e)

        {
            move(pictureBox_blackpawn1, BlackPawn1_selected, BlackPawn1_xy, a4c);
            move(pictureBox_blackpawn2, BlackPawn2_selected, BlackPawn2_xy, a4c);
            move(pictureBox_blackpawn3, BlackPawn3_selected, BlackPawn3_xy, a4c);
            move(pictureBox_blackpawn4, BlackPawn4_selected, BlackPawn4_xy, a4c);
            move(pictureBox_blackpawn5, BlackPawn5_selected, BlackPawn5_xy, a4c);
            move(pictureBox_blackpawn6, BlackPawn6_selected, BlackPawn6_xy, a4c);
            move(pictureBox_blackpawn7, BlackPawn7_selected, BlackPawn7_xy, a4c);
            move(pictureBox_blackpawn8, BlackPawn8_selected, BlackPawn8_xy, a4c);
            move(pictureBox_blackrook1, BlackRook1_selected, BlackRook1_xy, a4c);
            move(pictureBox_blackknight1, BlackKnight1_selected, BlackKnight1_xy, a4c);
            move(pictureBox_blackbishop1, BlackBishop1_selected, BlackBishop1_xy, a4c);
            move(pictureBox_blackqueen, BlackQueen_selected, BlackQueen_xy, a4c);
            move(pictureBox_blackking, BlackKing_selected, BlackKing_xy, a4c);
            move(pictureBox_blackbishop2, BlackBishop2_selected, BlackBishop2_xy, a4c);
            move(pictureBox_blackknight2, BlackKnight2_selected, BlackKnight2_xy, a4c);
            move(pictureBox_blackrook2, BlackRook2_selected, BlackRook2_xy, a4c);

            move(pictureBox_whitepawn1, WhitePawn1_selected, WhitePawn1_xy, a4c);
            move(pictureBox_whitepawn2, WhitePawn2_selected, WhitePawn2_xy, a4c);
            move(pictureBox_whitepawn3, WhitePawn3_selected, WhitePawn3_xy, a4c);
            move(pictureBox_whitepawn4, WhitePawn4_selected, WhitePawn4_xy, a4c);
            move(pictureBox_whitepawn5, WhitePawn5_selected, WhitePawn5_xy, a4c);
            move(pictureBox_whitepawn6, WhitePawn6_selected, WhitePawn6_xy, a4c);
            move(pictureBox_whitepawn7, WhitePawn7_selected, WhitePawn7_xy, a4c);
            move(pictureBox_whitepawn8, WhitePawn8_selected, WhitePawn8_xy, a4c);
            move(pictureBox_whiterook1, WhiteRook1_selected, WhiteRook1_xy, a4c);
            move(pictureBox_whiteknight1, WhiteKnight1_selected, WhiteKnight1_xy, a4c);
            move(pictureBox_whitebishop1, WhiteBishop1_selected, WhiteBishop1_xy, a4c);
            move(pictureBox_whitequeen, WhiteQueen_selected, WhiteQueen_xy, a4c);
            move(pictureBox_whiteking, WhiteKing_selected, WhiteKing_xy, a4c);
            move(pictureBox_whitebishop2, WhiteBishop2_selected, WhiteBishop2_xy, a4c);
            move(pictureBox_whiteknight2, WhiteKnight2_selected, WhiteKnight2_xy, a4c);
            move(pictureBox_whiterook2, WhiteRook2_selected, WhiteRook2_xy, a4c);
        }

        private void pictureBox_a5_Click(object sender, EventArgs e)

        {
            move(pictureBox_blackpawn1, BlackPawn1_selected, BlackPawn1_xy, a5c);
            move(pictureBox_blackpawn2, BlackPawn2_selected, BlackPawn2_xy, a5c);
            move(pictureBox_blackpawn3, BlackPawn3_selected, BlackPawn3_xy, a5c);
            move(pictureBox_blackpawn4, BlackPawn4_selected, BlackPawn4_xy, a5c);
            move(pictureBox_blackpawn5, BlackPawn5_selected, BlackPawn5_xy, a5c);
            move(pictureBox_blackpawn6, BlackPawn6_selected, BlackPawn6_xy, a5c);
            move(pictureBox_blackpawn7, BlackPawn7_selected, BlackPawn7_xy, a5c);
            move(pictureBox_blackpawn8, BlackPawn8_selected, BlackPawn8_xy, a5c);
            move(pictureBox_blackrook1, BlackRook1_selected, BlackRook1_xy, a5c);
            move(pictureBox_blackknight1, BlackKnight1_selected, BlackKnight1_xy, a5c);
            move(pictureBox_blackbishop1, BlackBishop1_selected, BlackBishop1_xy, a5c);
            move(pictureBox_blackqueen, BlackQueen_selected, BlackQueen_xy, a5c);
            move(pictureBox_blackking, BlackKing_selected, BlackKing_xy, a5c);
            move(pictureBox_blackbishop2, BlackBishop2_selected, BlackBishop2_xy, a5c);
            move(pictureBox_blackknight2, BlackKnight2_selected, BlackKnight2_xy, a5c);
            move(pictureBox_blackrook2, BlackRook2_selected, BlackRook2_xy, a5c);

            move(pictureBox_whitepawn1, WhitePawn1_selected, WhitePawn1_xy, a5c);
            move(pictureBox_whitepawn2, WhitePawn2_selected, WhitePawn2_xy, a5c);
            move(pictureBox_whitepawn3, WhitePawn3_selected, WhitePawn3_xy, a5c);
            move(pictureBox_whitepawn4, WhitePawn4_selected, WhitePawn4_xy, a5c);
            move(pictureBox_whitepawn5, WhitePawn5_selected, WhitePawn5_xy, a5c);
            move(pictureBox_whitepawn6, WhitePawn6_selected, WhitePawn6_xy, a5c);
            move(pictureBox_whitepawn7, WhitePawn7_selected, WhitePawn7_xy, a5c);
            move(pictureBox_whitepawn8, WhitePawn8_selected, WhitePawn8_xy, a5c);
            move(pictureBox_whiterook1, WhiteRook1_selected, WhiteRook1_xy, a5c);
            move(pictureBox_whiteknight1, WhiteKnight1_selected, WhiteKnight1_xy, a5c);
            move(pictureBox_whitebishop1, WhiteBishop1_selected, WhiteBishop1_xy, a5c);
            move(pictureBox_whitequeen, WhiteQueen_selected, WhiteQueen_xy, a5c);
            move(pictureBox_whiteking, WhiteKing_selected, WhiteKing_xy, a5c);
            move(pictureBox_whitebishop2, WhiteBishop2_selected, WhiteBishop2_xy, a5c);
            move(pictureBox_whiteknight2, WhiteKnight2_selected, WhiteKnight2_xy, a5c);
            move(pictureBox_whiterook2, WhiteRook2_selected, WhiteRook2_xy, a5c);
        }

        private void pictureBox_a6_Click(object sender, EventArgs e)

        {
            move(pictureBox_blackpawn1, BlackPawn1_selected, BlackPawn1_xy, a6c);
            move(pictureBox_blackpawn2, BlackPawn2_selected, BlackPawn2_xy, a6c);
            move(pictureBox_blackpawn3, BlackPawn3_selected, BlackPawn3_xy, a6c);
            move(pictureBox_blackpawn4, BlackPawn4_selected, BlackPawn4_xy, a6c);
            move(pictureBox_blackpawn5, BlackPawn5_selected, BlackPawn5_xy, a6c);
            move(pictureBox_blackpawn6, BlackPawn6_selected, BlackPawn6_xy, a6c);
            move(pictureBox_blackpawn7, BlackPawn7_selected, BlackPawn7_xy, a6c);
            move(pictureBox_blackpawn8, BlackPawn8_selected, BlackPawn8_xy, a6c);
            move(pictureBox_blackrook1, BlackRook1_selected, BlackRook1_xy, a6c);
            move(pictureBox_blackknight1, BlackKnight1_selected, BlackKnight1_xy, a6c);
            move(pictureBox_blackbishop1, BlackBishop1_selected, BlackBishop1_xy, a6c);
            move(pictureBox_blackqueen, BlackQueen_selected, BlackQueen_xy, a6c);
            move(pictureBox_blackking, BlackKing_selected, BlackKing_xy, a6c);
            move(pictureBox_blackbishop2, BlackBishop2_selected, BlackBishop2_xy, a6c);
            move(pictureBox_blackknight2, BlackKnight2_selected, BlackKnight2_xy, a6c);
            move(pictureBox_blackrook2, BlackRook2_selected, BlackRook2_xy, a6c);

            move(pictureBox_whitepawn1, WhitePawn1_selected, WhitePawn1_xy, a6c);
            move(pictureBox_whitepawn2, WhitePawn2_selected, WhitePawn2_xy, a6c);
            move(pictureBox_whitepawn3, WhitePawn3_selected, WhitePawn3_xy, a6c);
            move(pictureBox_whitepawn4, WhitePawn4_selected, WhitePawn4_xy, a6c);
            move(pictureBox_whitepawn5, WhitePawn5_selected, WhitePawn5_xy, a6c);
            move(pictureBox_whitepawn6, WhitePawn6_selected, WhitePawn6_xy, a6c);
            move(pictureBox_whitepawn7, WhitePawn7_selected, WhitePawn7_xy, a6c);
            move(pictureBox_whitepawn8, WhitePawn8_selected, WhitePawn8_xy, a6c);
            move(pictureBox_whiterook1, WhiteRook1_selected, WhiteRook1_xy, a6c);
            move(pictureBox_whiteknight1, WhiteKnight1_selected, WhiteKnight1_xy, a6c);
            move(pictureBox_whitebishop1, WhiteBishop1_selected, WhiteBishop1_xy, a6c);
            move(pictureBox_whitequeen, WhiteQueen_selected, WhiteQueen_xy, a6c);
            move(pictureBox_whiteking, WhiteKing_selected, WhiteKing_xy, a6c);
            move(pictureBox_whitebishop2, WhiteBishop2_selected, WhiteBishop2_xy, a6c);
            move(pictureBox_whiteknight2, WhiteKnight2_selected, WhiteKnight2_xy, a6c);
            move(pictureBox_whiterook2, WhiteRook2_selected, WhiteRook2_xy, a6c);
        }

        private void pictureBox_a7_Click(object sender, EventArgs e)

        {
            move(pictureBox_blackpawn1, BlackPawn1_selected, BlackPawn1_xy, a7c);
            move(pictureBox_blackpawn2, BlackPawn2_selected, BlackPawn2_xy, a7c);
            move(pictureBox_blackpawn3, BlackPawn3_selected, BlackPawn3_xy, a7c);
            move(pictureBox_blackpawn4, BlackPawn4_selected, BlackPawn4_xy, a7c);
            move(pictureBox_blackpawn5, BlackPawn5_selected, BlackPawn5_xy, a7c);
            move(pictureBox_blackpawn6, BlackPawn6_selected, BlackPawn6_xy, a7c);
            move(pictureBox_blackpawn7, BlackPawn7_selected, BlackPawn7_xy, a7c);
            move(pictureBox_blackpawn8, BlackPawn8_selected, BlackPawn8_xy, a7c);
            move(pictureBox_blackrook1, BlackRook1_selected, BlackRook1_xy, a7c);
            move(pictureBox_blackknight1, BlackKnight1_selected, BlackKnight1_xy, a7c);
            move(pictureBox_blackbishop1, BlackBishop1_selected, BlackBishop1_xy, a7c);
            move(pictureBox_blackqueen, BlackQueen_selected, BlackQueen_xy, a7c);
            move(pictureBox_blackking, BlackKing_selected, BlackKing_xy, a7c);
            move(pictureBox_blackbishop2, BlackBishop2_selected, BlackBishop2_xy, a7c);
            move(pictureBox_blackknight2, BlackKnight2_selected, BlackKnight2_xy, a7c);
            move(pictureBox_blackrook2, BlackRook2_selected, BlackRook2_xy, a7c);

            move(pictureBox_whitepawn1, WhitePawn1_selected, WhitePawn1_xy, a7c);
            move(pictureBox_whitepawn2, WhitePawn2_selected, WhitePawn2_xy, a7c);
            move(pictureBox_whitepawn3, WhitePawn3_selected, WhitePawn3_xy, a7c);
            move(pictureBox_whitepawn4, WhitePawn4_selected, WhitePawn4_xy, a7c);
            move(pictureBox_whitepawn5, WhitePawn5_selected, WhitePawn5_xy, a7c);
            move(pictureBox_whitepawn6, WhitePawn6_selected, WhitePawn6_xy, a7c);
            move(pictureBox_whitepawn7, WhitePawn7_selected, WhitePawn7_xy, a7c);
            move(pictureBox_whitepawn8, WhitePawn8_selected, WhitePawn8_xy, a7c);
            move(pictureBox_whiterook1, WhiteRook1_selected, WhiteRook1_xy, a7c);
            move(pictureBox_whiteknight1, WhiteKnight1_selected, WhiteKnight1_xy, a7c);
            move(pictureBox_whitebishop1, WhiteBishop1_selected, WhiteBishop1_xy, a7c);
            move(pictureBox_whitequeen, WhiteQueen_selected, WhiteQueen_xy, a7c);
            move(pictureBox_whiteking, WhiteKing_selected, WhiteKing_xy, a7c);
            move(pictureBox_whitebishop2, WhiteBishop2_selected, WhiteBishop2_xy, a7c);
            move(pictureBox_whiteknight2, WhiteKnight2_selected, WhiteKnight2_xy, a7c);
            move(pictureBox_whiterook2, WhiteRook2_selected, WhiteRook2_xy, a7c);
        }

        private void pictureBox_a8_Click(object sender, EventArgs e)

        {
            move(pictureBox_blackpawn1, BlackPawn1_selected, BlackPawn1_xy, a8c);
            move(pictureBox_blackpawn2, BlackPawn2_selected, BlackPawn2_xy, a8c);
            move(pictureBox_blackpawn3, BlackPawn3_selected, BlackPawn3_xy, a8c);
            move(pictureBox_blackpawn4, BlackPawn4_selected, BlackPawn4_xy, a8c);
            move(pictureBox_blackpawn5, BlackPawn5_selected, BlackPawn5_xy, a8c);
            move(pictureBox_blackpawn6, BlackPawn6_selected, BlackPawn6_xy, a8c);
            move(pictureBox_blackpawn7, BlackPawn7_selected, BlackPawn7_xy, a8c);
            move(pictureBox_blackpawn8, BlackPawn8_selected, BlackPawn8_xy, a8c);
            move(pictureBox_blackrook1, BlackRook1_selected, BlackRook1_xy, a8c);
            move(pictureBox_blackknight1, BlackKnight1_selected, BlackKnight1_xy, a8c);
            move(pictureBox_blackbishop1, BlackBishop1_selected, BlackBishop1_xy, a8c);
            move(pictureBox_blackqueen, BlackQueen_selected, BlackQueen_xy, a8c);
            move(pictureBox_blackking, BlackKing_selected, BlackKing_xy, a8c);
            move(pictureBox_blackbishop2, BlackBishop2_selected, BlackBishop2_xy, a8c);
            move(pictureBox_blackknight2, BlackKnight2_selected, BlackKnight2_xy, a8c);
            move(pictureBox_blackrook2, BlackRook2_selected, BlackRook2_xy, a8c);

            move(pictureBox_whitepawn1, WhitePawn1_selected, WhitePawn1_xy, a8c);
            move(pictureBox_whitepawn2, WhitePawn2_selected, WhitePawn2_xy, a8c);
            move(pictureBox_whitepawn3, WhitePawn3_selected, WhitePawn3_xy, a8c);
            move(pictureBox_whitepawn4, WhitePawn4_selected, WhitePawn4_xy, a8c);
            move(pictureBox_whitepawn5, WhitePawn5_selected, WhitePawn5_xy, a8c);
            move(pictureBox_whitepawn6, WhitePawn6_selected, WhitePawn6_xy, a8c);
            move(pictureBox_whitepawn7, WhitePawn7_selected, WhitePawn7_xy, a8c);
            move(pictureBox_whitepawn8, WhitePawn8_selected, WhitePawn8_xy, a8c);
            move(pictureBox_whiterook1, WhiteRook1_selected, WhiteRook1_xy, a8c);
            move(pictureBox_whiteknight1, WhiteKnight1_selected, WhiteKnight1_xy, a8c);
            move(pictureBox_whitebishop1, WhiteBishop1_selected, WhiteBishop1_xy, a8c);
            move(pictureBox_whitequeen, WhiteQueen_selected, WhiteQueen_xy, a8c);
            move(pictureBox_whiteking, WhiteKing_selected, WhiteKing_xy, a8c);
            move(pictureBox_whitebishop2, WhiteBishop2_selected, WhiteBishop2_xy, a8c);
            move(pictureBox_whiteknight2, WhiteKnight2_selected, WhiteKnight2_xy, a8c);
            move(pictureBox_whiterook2, WhiteRook2_selected, WhiteRook2_xy, a8c);
        }


        private void pictureBox_b1_Click(object sender, EventArgs e)

        {
            move(pictureBox_blackpawn1, BlackPawn1_selected, BlackPawn1_xy, b1c);
            move(pictureBox_blackpawn2, BlackPawn2_selected, BlackPawn2_xy, b1c);
            move(pictureBox_blackpawn3, BlackPawn3_selected, BlackPawn3_xy, b1c);
            move(pictureBox_blackpawn4, BlackPawn4_selected, BlackPawn4_xy, b1c);
            move(pictureBox_blackpawn5, BlackPawn5_selected, BlackPawn5_xy, b1c);
            move(pictureBox_blackpawn6, BlackPawn6_selected, BlackPawn6_xy, b1c);
            move(pictureBox_blackpawn7, BlackPawn7_selected, BlackPawn7_xy, b1c);
            move(pictureBox_blackpawn8, BlackPawn8_selected, BlackPawn8_xy, b1c);
            move(pictureBox_blackrook1, BlackRook1_selected, BlackRook1_xy, b1c);
            move(pictureBox_blackknight1, BlackKnight1_selected, BlackKnight1_xy, b1c);
            move(pictureBox_blackbishop1, BlackBishop1_selected, BlackBishop1_xy, b1c);
            move(pictureBox_blackqueen, BlackQueen_selected, BlackQueen_xy, b1c);
            move(pictureBox_blackking, BlackKing_selected, BlackKing_xy, b1c);
            move(pictureBox_blackbishop2, BlackBishop2_selected, BlackBishop2_xy, b1c);
            move(pictureBox_blackknight2, BlackKnight2_selected, BlackKnight2_xy, b1c);
            move(pictureBox_blackrook2, BlackRook2_selected, BlackRook2_xy, b1c);

            move(pictureBox_whitepawn1, WhitePawn1_selected, WhitePawn1_xy, b1c);
            move(pictureBox_whitepawn2, WhitePawn2_selected, WhitePawn2_xy, b1c);
            move(pictureBox_whitepawn3, WhitePawn3_selected, WhitePawn3_xy, b1c);
            move(pictureBox_whitepawn4, WhitePawn4_selected, WhitePawn4_xy, b1c);
            move(pictureBox_whitepawn5, WhitePawn5_selected, WhitePawn5_xy, b1c);
            move(pictureBox_whitepawn6, WhitePawn6_selected, WhitePawn6_xy, b1c);
            move(pictureBox_whitepawn7, WhitePawn7_selected, WhitePawn7_xy, b1c);
            move(pictureBox_whitepawn8, WhitePawn8_selected, WhitePawn8_xy, b1c);
            move(pictureBox_whiterook1, WhiteRook1_selected, WhiteRook1_xy, b1c);
            move(pictureBox_whiteknight1, WhiteKnight1_selected, WhiteKnight1_xy, b1c);
            move(pictureBox_whitebishop1, WhiteBishop1_selected, WhiteBishop1_xy, b1c);
            move(pictureBox_whitequeen, WhiteQueen_selected, WhiteQueen_xy, b1c);
            move(pictureBox_whiteking, WhiteKing_selected, WhiteKing_xy, b1c);
            move(pictureBox_whitebishop2, WhiteBishop2_selected, WhiteBishop2_xy, b1c);
            move(pictureBox_whiteknight2, WhiteKnight2_selected, WhiteKnight2_xy, b1c);
            move(pictureBox_whiterook2, WhiteRook2_selected, WhiteRook2_xy, b1c);
        }

        private void pictureBox_b2_Click(object sender, EventArgs e)
        {
            move(pictureBox_blackpawn1, BlackPawn1_selected, BlackPawn1_xy, b2c);
            move(pictureBox_blackpawn2, BlackPawn2_selected, BlackPawn2_xy, b2c);
            move(pictureBox_blackpawn3, BlackPawn3_selected, BlackPawn3_xy, b2c);
            move(pictureBox_blackpawn4, BlackPawn4_selected, BlackPawn4_xy, b2c);
            move(pictureBox_blackpawn5, BlackPawn5_selected, BlackPawn5_xy, b2c);
            move(pictureBox_blackpawn6, BlackPawn6_selected, BlackPawn6_xy, b2c);
            move(pictureBox_blackpawn7, BlackPawn7_selected, BlackPawn7_xy, b2c);
            move(pictureBox_blackpawn8, BlackPawn8_selected, BlackPawn8_xy, b2c);
            move(pictureBox_blackrook1, BlackRook1_selected, BlackRook1_xy, b2c);
            move(pictureBox_blackknight1, BlackKnight1_selected, BlackKnight1_xy, b2c);
            move(pictureBox_blackbishop1, BlackBishop1_selected, BlackBishop1_xy, b2c);
            move(pictureBox_blackqueen, BlackQueen_selected, BlackQueen_xy, b2c);
            move(pictureBox_blackking, BlackKing_selected, BlackKing_xy, b2c);
            move(pictureBox_blackbishop2, BlackBishop2_selected, BlackBishop2_xy, b2c);
            move(pictureBox_blackknight2, BlackKnight2_selected, BlackKnight2_xy, b2c);
            move(pictureBox_blackrook2, BlackRook2_selected, BlackRook2_xy, b2c);

            move(pictureBox_whitepawn1, WhitePawn1_selected, WhitePawn1_xy, b2c);
            move(pictureBox_whitepawn2, WhitePawn2_selected, WhitePawn2_xy, b2c);
            move(pictureBox_whitepawn3, WhitePawn3_selected, WhitePawn3_xy, b2c);
            move(pictureBox_whitepawn4, WhitePawn4_selected, WhitePawn4_xy, b2c);
            move(pictureBox_whitepawn5, WhitePawn5_selected, WhitePawn5_xy, b2c);
            move(pictureBox_whitepawn6, WhitePawn6_selected, WhitePawn6_xy, b2c);
            move(pictureBox_whitepawn7, WhitePawn7_selected, WhitePawn7_xy, b2c);
            move(pictureBox_whitepawn8, WhitePawn8_selected, WhitePawn8_xy, b2c);
            move(pictureBox_whiterook1, WhiteRook1_selected, WhiteRook1_xy, b2c);
            move(pictureBox_whiteknight1, WhiteKnight1_selected, WhiteKnight1_xy, b2c);
            move(pictureBox_whitebishop1, WhiteBishop1_selected, WhiteBishop1_xy, b2c);
            move(pictureBox_whitequeen, WhiteQueen_selected, WhiteQueen_xy, b2c);
            move(pictureBox_whiteking, WhiteKing_selected, WhiteKing_xy, b2c);
            move(pictureBox_whitebishop2, WhiteBishop2_selected, WhiteBishop2_xy, b2c);
            move(pictureBox_whiteknight2, WhiteKnight2_selected, WhiteKnight2_xy, b2c);
            move(pictureBox_whiterook2, WhiteRook2_selected, WhiteRook2_xy, b2c);
        }

        private void pictureBox_b3_Click(object sender, EventArgs e)

        {
            move(pictureBox_blackpawn1, BlackPawn1_selected, BlackPawn1_xy, b3c);
            move(pictureBox_blackpawn2, BlackPawn2_selected, BlackPawn2_xy, b3c);
            move(pictureBox_blackpawn3, BlackPawn3_selected, BlackPawn3_xy, b3c);
            move(pictureBox_blackpawn4, BlackPawn4_selected, BlackPawn4_xy, b3c);
            move(pictureBox_blackpawn5, BlackPawn5_selected, BlackPawn5_xy, b3c);
            move(pictureBox_blackpawn6, BlackPawn6_selected, BlackPawn6_xy, b3c);
            move(pictureBox_blackpawn7, BlackPawn7_selected, BlackPawn7_xy, b3c);
            move(pictureBox_blackpawn8, BlackPawn8_selected, BlackPawn8_xy, b3c);
            move(pictureBox_blackrook1, BlackRook1_selected, BlackRook1_xy, b3c);
            move(pictureBox_blackknight1, BlackKnight1_selected, BlackKnight1_xy, b3c);
            move(pictureBox_blackbishop1, BlackBishop1_selected, BlackBishop1_xy, b3c);
            move(pictureBox_blackqueen, BlackQueen_selected, BlackQueen_xy, b3c);
            move(pictureBox_blackking, BlackKing_selected, BlackKing_xy, b3c);
            move(pictureBox_blackbishop2, BlackBishop2_selected, BlackBishop2_xy, b3c);
            move(pictureBox_blackknight2, BlackKnight2_selected, BlackKnight2_xy, b3c);
            move(pictureBox_blackrook2, BlackRook2_selected, BlackRook2_xy, b3c);

            move(pictureBox_whitepawn1, WhitePawn1_selected, WhitePawn1_xy, b3c);
            move(pictureBox_whitepawn2, WhitePawn2_selected, WhitePawn2_xy, b3c);
            move(pictureBox_whitepawn3, WhitePawn3_selected, WhitePawn3_xy, b3c);
            move(pictureBox_whitepawn4, WhitePawn4_selected, WhitePawn4_xy, b3c);
            move(pictureBox_whitepawn5, WhitePawn5_selected, WhitePawn5_xy, b3c);
            move(pictureBox_whitepawn6, WhitePawn6_selected, WhitePawn6_xy, b3c);
            move(pictureBox_whitepawn7, WhitePawn7_selected, WhitePawn7_xy, b3c);
            move(pictureBox_whitepawn8, WhitePawn8_selected, WhitePawn8_xy, b3c);
            move(pictureBox_whiterook1, WhiteRook1_selected, WhiteRook1_xy, b3c);
            move(pictureBox_whiteknight1, WhiteKnight1_selected, WhiteKnight1_xy, b3c);
            move(pictureBox_whitebishop1, WhiteBishop1_selected, WhiteBishop1_xy, b3c);
            move(pictureBox_whitequeen, WhiteQueen_selected, WhiteQueen_xy, b3c);
            move(pictureBox_whiteking, WhiteKing_selected, WhiteKing_xy, b3c);
            move(pictureBox_whitebishop2, WhiteBishop2_selected, WhiteBishop2_xy, b3c);
            move(pictureBox_whiteknight2, WhiteKnight2_selected, WhiteKnight2_xy, b3c);
            move(pictureBox_whiterook2, WhiteRook2_selected, WhiteRook2_xy, b3c);
        }

        private void pictureBox_b4_Click(object sender, EventArgs e)

        {
            move(pictureBox_blackpawn1, BlackPawn1_selected, BlackPawn1_xy, b4c);
            move(pictureBox_blackpawn2, BlackPawn2_selected, BlackPawn2_xy, b4c);
            move(pictureBox_blackpawn3, BlackPawn3_selected, BlackPawn3_xy, b4c);
            move(pictureBox_blackpawn4, BlackPawn4_selected, BlackPawn4_xy, b4c);
            move(pictureBox_blackpawn5, BlackPawn5_selected, BlackPawn5_xy, b4c);
            move(pictureBox_blackpawn6, BlackPawn6_selected, BlackPawn6_xy, b4c);
            move(pictureBox_blackpawn7, BlackPawn7_selected, BlackPawn7_xy, b4c);
            move(pictureBox_blackpawn8, BlackPawn8_selected, BlackPawn8_xy, b4c);
            move(pictureBox_blackrook1, BlackRook1_selected, BlackRook1_xy, b4c);
            move(pictureBox_blackknight1, BlackKnight1_selected, BlackKnight1_xy, b4c);
            move(pictureBox_blackbishop1, BlackBishop1_selected, BlackBishop1_xy, b4c);
            move(pictureBox_blackqueen, BlackQueen_selected, BlackQueen_xy, b4c);
            move(pictureBox_blackking, BlackKing_selected, BlackKing_xy, b4c);
            move(pictureBox_blackbishop2, BlackBishop2_selected, BlackBishop2_xy, b4c);
            move(pictureBox_blackknight2, BlackKnight2_selected, BlackKnight2_xy, b4c);
            move(pictureBox_blackrook2, BlackRook2_selected, BlackRook2_xy, b4c);

            move(pictureBox_whitepawn1, WhitePawn1_selected, WhitePawn1_xy, b4c);
            move(pictureBox_whitepawn2, WhitePawn2_selected, WhitePawn2_xy, b4c);
            move(pictureBox_whitepawn3, WhitePawn3_selected, WhitePawn3_xy, b4c);
            move(pictureBox_whitepawn4, WhitePawn4_selected, WhitePawn4_xy, b4c);
            move(pictureBox_whitepawn5, WhitePawn5_selected, WhitePawn5_xy, b4c);
            move(pictureBox_whitepawn6, WhitePawn6_selected, WhitePawn6_xy, b4c);
            move(pictureBox_whitepawn7, WhitePawn7_selected, WhitePawn7_xy, b4c);
            move(pictureBox_whitepawn8, WhitePawn8_selected, WhitePawn8_xy, b4c);
            move(pictureBox_whiterook1, WhiteRook1_selected, WhiteRook1_xy, b4c);
            move(pictureBox_whiteknight1, WhiteKnight1_selected, WhiteKnight1_xy, b4c);
            move(pictureBox_whitebishop1, WhiteBishop1_selected, WhiteBishop1_xy, b4c);
            move(pictureBox_whitequeen, WhiteQueen_selected, WhiteQueen_xy, b4c);
            move(pictureBox_whiteking, WhiteKing_selected, WhiteKing_xy, b4c);
            move(pictureBox_whitebishop2, WhiteBishop2_selected, WhiteBishop2_xy, b4c);
            move(pictureBox_whiteknight2, WhiteKnight2_selected, WhiteKnight2_xy, b4c);
            move(pictureBox_whiterook2, WhiteRook2_selected, WhiteRook2_xy, b4c);
        }

        private void pictureBox_b5_Click(object sender, EventArgs e)

        {
            move(pictureBox_blackpawn1, BlackPawn1_selected, BlackPawn1_xy, b5c);
            move(pictureBox_blackpawn2, BlackPawn2_selected, BlackPawn2_xy, b5c);
            move(pictureBox_blackpawn3, BlackPawn3_selected, BlackPawn3_xy, b5c);
            move(pictureBox_blackpawn4, BlackPawn4_selected, BlackPawn4_xy, b5c);
            move(pictureBox_blackpawn5, BlackPawn5_selected, BlackPawn5_xy, b5c);
            move(pictureBox_blackpawn6, BlackPawn6_selected, BlackPawn6_xy, b5c);
            move(pictureBox_blackpawn7, BlackPawn7_selected, BlackPawn7_xy, b5c);
            move(pictureBox_blackpawn8, BlackPawn8_selected, BlackPawn8_xy, b5c);
            move(pictureBox_blackrook1, BlackRook1_selected, BlackRook1_xy, b5c);
            move(pictureBox_blackknight1, BlackKnight1_selected, BlackKnight1_xy, b5c);
            move(pictureBox_blackbishop1, BlackBishop1_selected, BlackBishop1_xy, b5c);
            move(pictureBox_blackqueen, BlackQueen_selected, BlackQueen_xy, b5c);
            move(pictureBox_blackking, BlackKing_selected, BlackKing_xy, b5c);
            move(pictureBox_blackbishop2, BlackBishop2_selected, BlackBishop2_xy, b5c);
            move(pictureBox_blackknight2, BlackKnight2_selected, BlackKnight2_xy, b5c);
            move(pictureBox_blackrook2, BlackRook2_selected, BlackRook2_xy, b5c);

            move(pictureBox_whitepawn1, WhitePawn1_selected, WhitePawn1_xy, b5c);
            move(pictureBox_whitepawn2, WhitePawn2_selected, WhitePawn2_xy, b5c);
            move(pictureBox_whitepawn3, WhitePawn3_selected, WhitePawn3_xy, b5c);
            move(pictureBox_whitepawn4, WhitePawn4_selected, WhitePawn4_xy, b5c);
            move(pictureBox_whitepawn5, WhitePawn5_selected, WhitePawn5_xy, b5c);
            move(pictureBox_whitepawn6, WhitePawn6_selected, WhitePawn6_xy, b5c);
            move(pictureBox_whitepawn7, WhitePawn7_selected, WhitePawn7_xy, b5c);
            move(pictureBox_whitepawn8, WhitePawn8_selected, WhitePawn8_xy, b5c);
            move(pictureBox_whiterook1, WhiteRook1_selected, WhiteRook1_xy, b5c);
            move(pictureBox_whiteknight1, WhiteKnight1_selected, WhiteKnight1_xy, b5c);
            move(pictureBox_whitebishop1, WhiteBishop1_selected, WhiteBishop1_xy, b5c);
            move(pictureBox_whitequeen, WhiteQueen_selected, WhiteQueen_xy, b5c);
            move(pictureBox_whiteking, WhiteKing_selected, WhiteKing_xy, b5c);
            move(pictureBox_whitebishop2, WhiteBishop2_selected, WhiteBishop2_xy, b5c);
            move(pictureBox_whiteknight2, WhiteKnight2_selected, WhiteKnight2_xy, b5c);
            move(pictureBox_whiterook2, WhiteRook2_selected, WhiteRook2_xy, b5c);
        }

        private void pictureBox_b6_Click(object sender, EventArgs e)

        {
            move(pictureBox_blackpawn1, BlackPawn1_selected, BlackPawn1_xy, b6c);
            move(pictureBox_blackpawn2, BlackPawn2_selected, BlackPawn2_xy, b6c);
            move(pictureBox_blackpawn3, BlackPawn3_selected, BlackPawn3_xy, b6c);
            move(pictureBox_blackpawn4, BlackPawn4_selected, BlackPawn4_xy, b6c);
            move(pictureBox_blackpawn5, BlackPawn5_selected, BlackPawn5_xy, b6c);
            move(pictureBox_blackpawn6, BlackPawn6_selected, BlackPawn6_xy, b6c);
            move(pictureBox_blackpawn7, BlackPawn7_selected, BlackPawn7_xy, b6c);
            move(pictureBox_blackpawn8, BlackPawn8_selected, BlackPawn8_xy, b6c);
            move(pictureBox_blackrook1, BlackRook1_selected, BlackRook1_xy, b6c);
            move(pictureBox_blackknight1, BlackKnight1_selected, BlackKnight1_xy, b6c);
            move(pictureBox_blackbishop1, BlackBishop1_selected, BlackBishop1_xy, b6c);
            move(pictureBox_blackqueen, BlackQueen_selected, BlackQueen_xy, b6c);
            move(pictureBox_blackking, BlackKing_selected, BlackKing_xy, b6c);
            move(pictureBox_blackbishop2, BlackBishop2_selected, BlackBishop2_xy, b6c);
            move(pictureBox_blackknight2, BlackKnight2_selected, BlackKnight2_xy, b6c);
            move(pictureBox_blackrook2, BlackRook2_selected, BlackRook2_xy, b6c);

            move(pictureBox_whitepawn1, WhitePawn1_selected, WhitePawn1_xy, b6c);
            move(pictureBox_whitepawn2, WhitePawn2_selected, WhitePawn2_xy, b6c);
            move(pictureBox_whitepawn3, WhitePawn3_selected, WhitePawn3_xy, b6c);
            move(pictureBox_whitepawn4, WhitePawn4_selected, WhitePawn4_xy, b6c);
            move(pictureBox_whitepawn5, WhitePawn5_selected, WhitePawn5_xy, b6c);
            move(pictureBox_whitepawn6, WhitePawn6_selected, WhitePawn6_xy, b6c);
            move(pictureBox_whitepawn7, WhitePawn7_selected, WhitePawn7_xy, b6c);
            move(pictureBox_whitepawn8, WhitePawn8_selected, WhitePawn8_xy, b6c);
            move(pictureBox_whiterook1, WhiteRook1_selected, WhiteRook1_xy, b6c);
            move(pictureBox_whiteknight1, WhiteKnight1_selected, WhiteKnight1_xy, b6c);
            move(pictureBox_whitebishop1, WhiteBishop1_selected, WhiteBishop1_xy, b6c);
            move(pictureBox_whitequeen, WhiteQueen_selected, WhiteQueen_xy, b6c);
            move(pictureBox_whiteking, WhiteKing_selected, WhiteKing_xy, b6c);
            move(pictureBox_whitebishop2, WhiteBishop2_selected, WhiteBishop2_xy, b6c);
            move(pictureBox_whiteknight2, WhiteKnight2_selected, WhiteKnight2_xy, b6c);
            move(pictureBox_whiterook2, WhiteRook2_selected, WhiteRook2_xy, b6c);
        }

        private void pictureBox_b7_Click(object sender, EventArgs e)

        {
            move(pictureBox_blackpawn1, BlackPawn1_selected, BlackPawn1_xy, b7c);
            move(pictureBox_blackpawn2, BlackPawn2_selected, BlackPawn2_xy, b7c);
            move(pictureBox_blackpawn3, BlackPawn3_selected, BlackPawn3_xy, b7c);
            move(pictureBox_blackpawn4, BlackPawn4_selected, BlackPawn4_xy, b7c);
            move(pictureBox_blackpawn5, BlackPawn5_selected, BlackPawn5_xy, b7c);
            move(pictureBox_blackpawn6, BlackPawn6_selected, BlackPawn6_xy, b7c);
            move(pictureBox_blackpawn7, BlackPawn7_selected, BlackPawn7_xy, b7c);
            move(pictureBox_blackpawn8, BlackPawn8_selected, BlackPawn8_xy, b7c);
            move(pictureBox_blackrook1, BlackRook1_selected, BlackRook1_xy, b7c);
            move(pictureBox_blackknight1, BlackKnight1_selected, BlackKnight1_xy, b7c);
            move(pictureBox_blackbishop1, BlackBishop1_selected, BlackBishop1_xy, b7c);
            move(pictureBox_blackqueen, BlackQueen_selected, BlackQueen_xy, b7c);
            move(pictureBox_blackking, BlackKing_selected, BlackKing_xy, b7c);
            move(pictureBox_blackbishop2, BlackBishop2_selected, BlackBishop2_xy, b7c);
            move(pictureBox_blackknight2, BlackKnight2_selected, BlackKnight2_xy, b7c);
            move(pictureBox_blackrook2, BlackRook2_selected, BlackRook2_xy, b7c);

            move(pictureBox_whitepawn1, WhitePawn1_selected, WhitePawn1_xy, b7c);
            move(pictureBox_whitepawn2, WhitePawn2_selected, WhitePawn2_xy, b7c);
            move(pictureBox_whitepawn3, WhitePawn3_selected, WhitePawn3_xy, b7c);
            move(pictureBox_whitepawn4, WhitePawn4_selected, WhitePawn4_xy, b7c);
            move(pictureBox_whitepawn5, WhitePawn5_selected, WhitePawn5_xy, b7c);
            move(pictureBox_whitepawn6, WhitePawn6_selected, WhitePawn6_xy, b7c);
            move(pictureBox_whitepawn7, WhitePawn7_selected, WhitePawn7_xy, b7c);
            move(pictureBox_whitepawn8, WhitePawn8_selected, WhitePawn8_xy, b7c);
            move(pictureBox_whiterook1, WhiteRook1_selected, WhiteRook1_xy, b7c);
            move(pictureBox_whiteknight1, WhiteKnight1_selected, WhiteKnight1_xy, b7c);
            move(pictureBox_whitebishop1, WhiteBishop1_selected, WhiteBishop1_xy, b7c);
            move(pictureBox_whitequeen, WhiteQueen_selected, WhiteQueen_xy, b7c);
            move(pictureBox_whiteking, WhiteKing_selected, WhiteKing_xy, b7c);
            move(pictureBox_whitebishop2, WhiteBishop2_selected, WhiteBishop2_xy, b7c);
            move(pictureBox_whiteknight2, WhiteKnight2_selected, WhiteKnight2_xy, b7c);
            move(pictureBox_whiterook2, WhiteRook2_selected, WhiteRook2_xy, b7c);
        }

        private void pictureBox_b8_Click(object sender, EventArgs e)

        {
            move(pictureBox_blackpawn1, BlackPawn1_selected, BlackPawn1_xy, b8c);
            move(pictureBox_blackpawn2, BlackPawn2_selected, BlackPawn2_xy, b8c);
            move(pictureBox_blackpawn3, BlackPawn3_selected, BlackPawn3_xy, b8c);
            move(pictureBox_blackpawn4, BlackPawn4_selected, BlackPawn4_xy, b8c);
            move(pictureBox_blackpawn5, BlackPawn5_selected, BlackPawn5_xy, b8c);
            move(pictureBox_blackpawn6, BlackPawn6_selected, BlackPawn6_xy, b8c);
            move(pictureBox_blackpawn7, BlackPawn7_selected, BlackPawn7_xy, b8c);
            move(pictureBox_blackpawn8, BlackPawn8_selected, BlackPawn8_xy, b8c);
            move(pictureBox_blackrook1, BlackRook1_selected, BlackRook1_xy, b8c);
            move(pictureBox_blackknight1, BlackKnight1_selected, BlackKnight1_xy, b8c);
            move(pictureBox_blackbishop1, BlackBishop1_selected, BlackBishop1_xy, b8c);
            move(pictureBox_blackqueen, BlackQueen_selected, BlackQueen_xy, b8c);
            move(pictureBox_blackking, BlackKing_selected, BlackKing_xy, b8c);
            move(pictureBox_blackbishop2, BlackBishop2_selected, BlackBishop2_xy, b8c);
            move(pictureBox_blackknight2, BlackKnight2_selected, BlackKnight2_xy, b8c);
            move(pictureBox_blackrook2, BlackRook2_selected, BlackRook2_xy, b8c);

            move(pictureBox_whitepawn1, WhitePawn1_selected, WhitePawn1_xy, b8c);
            move(pictureBox_whitepawn2, WhitePawn2_selected, WhitePawn2_xy, b8c);
            move(pictureBox_whitepawn3, WhitePawn3_selected, WhitePawn3_xy, b8c);
            move(pictureBox_whitepawn4, WhitePawn4_selected, WhitePawn4_xy, b8c);
            move(pictureBox_whitepawn5, WhitePawn5_selected, WhitePawn5_xy, b8c);
            move(pictureBox_whitepawn6, WhitePawn6_selected, WhitePawn6_xy, b8c);
            move(pictureBox_whitepawn7, WhitePawn7_selected, WhitePawn7_xy, b8c);
            move(pictureBox_whitepawn8, WhitePawn8_selected, WhitePawn8_xy, b8c);
            move(pictureBox_whiterook1, WhiteRook1_selected, WhiteRook1_xy, b8c);
            move(pictureBox_whiteknight1, WhiteKnight1_selected, WhiteKnight1_xy, b8c);
            move(pictureBox_whitebishop1, WhiteBishop1_selected, WhiteBishop1_xy, b8c);
            move(pictureBox_whitequeen, WhiteQueen_selected, WhiteQueen_xy, b8c);
            move(pictureBox_whiteking, WhiteKing_selected, WhiteKing_xy, b8c);
            move(pictureBox_whitebishop2, WhiteBishop2_selected, WhiteBishop2_xy, b8c);
            move(pictureBox_whiteknight2, WhiteKnight2_selected, WhiteKnight2_xy, b8c);
            move(pictureBox_whiterook2, WhiteRook2_selected, WhiteRook2_xy, b8c);
        }


        private void pictureBox_c1_Click(object sender, EventArgs e)

        {
            move(pictureBox_blackpawn1, BlackPawn1_selected, BlackPawn1_xy, c1c);
            move(pictureBox_blackpawn2, BlackPawn2_selected, BlackPawn2_xy, c1c);
            move(pictureBox_blackpawn3, BlackPawn3_selected, BlackPawn3_xy, c1c);
            move(pictureBox_blackpawn4, BlackPawn4_selected, BlackPawn4_xy, c1c);
            move(pictureBox_blackpawn5, BlackPawn5_selected, BlackPawn5_xy, c1c);
            move(pictureBox_blackpawn6, BlackPawn6_selected, BlackPawn6_xy, c1c);
            move(pictureBox_blackpawn7, BlackPawn7_selected, BlackPawn7_xy, c1c);
            move(pictureBox_blackpawn8, BlackPawn8_selected, BlackPawn8_xy, c1c);
            move(pictureBox_blackrook1, BlackRook1_selected, BlackRook1_xy, c1c);
            move(pictureBox_blackknight1, BlackKnight1_selected, BlackKnight1_xy, c1c);
            move(pictureBox_blackbishop1, BlackBishop1_selected, BlackBishop1_xy, c1c);
            move(pictureBox_blackqueen, BlackQueen_selected, BlackQueen_xy, c1c);
            move(pictureBox_blackking, BlackKing_selected, BlackKing_xy, c1c);
            move(pictureBox_blackbishop2, BlackBishop2_selected, BlackBishop2_xy, c1c);
            move(pictureBox_blackknight2, BlackKnight2_selected, BlackKnight2_xy, c1c);
            move(pictureBox_blackrook2, BlackRook2_selected, BlackRook2_xy, c1c);

            move(pictureBox_whitepawn1, WhitePawn1_selected, WhitePawn1_xy, c1c);
            move(pictureBox_whitepawn2, WhitePawn2_selected, WhitePawn2_xy, c1c);
            move(pictureBox_whitepawn3, WhitePawn3_selected, WhitePawn3_xy, c1c);
            move(pictureBox_whitepawn4, WhitePawn4_selected, WhitePawn4_xy, c1c);
            move(pictureBox_whitepawn5, WhitePawn5_selected, WhitePawn5_xy, c1c);
            move(pictureBox_whitepawn6, WhitePawn6_selected, WhitePawn6_xy, c1c);
            move(pictureBox_whitepawn7, WhitePawn7_selected, WhitePawn7_xy, c1c);
            move(pictureBox_whitepawn8, WhitePawn8_selected, WhitePawn8_xy, c1c);
            move(pictureBox_whiterook1, WhiteRook1_selected, WhiteRook1_xy, c1c);
            move(pictureBox_whiteknight1, WhiteKnight1_selected, WhiteKnight1_xy, c1c);
            move(pictureBox_whitebishop1, WhiteBishop1_selected, WhiteBishop1_xy, c1c);
            move(pictureBox_whitequeen, WhiteQueen_selected, WhiteQueen_xy, c1c);
            move(pictureBox_whiteking, WhiteKing_selected, WhiteKing_xy, c1c);
            move(pictureBox_whitebishop2, WhiteBishop2_selected, WhiteBishop2_xy, c1c);
            move(pictureBox_whiteknight2, WhiteKnight2_selected, WhiteKnight2_xy, c1c);
            move(pictureBox_whiterook2, WhiteRook2_selected, WhiteRook2_xy, c1c);
        }

        private void pictureBox_c2_Click(object sender, EventArgs e)

        {
            move(pictureBox_blackpawn1, BlackPawn1_selected, BlackPawn1_xy, c2c);
            move(pictureBox_blackpawn2, BlackPawn2_selected, BlackPawn2_xy, c2c);
            move(pictureBox_blackpawn3, BlackPawn3_selected, BlackPawn3_xy, c2c);
            move(pictureBox_blackpawn4, BlackPawn4_selected, BlackPawn4_xy, c2c);
            move(pictureBox_blackpawn5, BlackPawn5_selected, BlackPawn5_xy, c2c);
            move(pictureBox_blackpawn6, BlackPawn6_selected, BlackPawn6_xy, c2c);
            move(pictureBox_blackpawn7, BlackPawn7_selected, BlackPawn7_xy, c2c);
            move(pictureBox_blackpawn8, BlackPawn8_selected, BlackPawn8_xy, c2c);
            move(pictureBox_blackrook1, BlackRook1_selected, BlackRook1_xy, c2c);
            move(pictureBox_blackknight1, BlackKnight1_selected, BlackKnight1_xy, c2c);
            move(pictureBox_blackbishop1, BlackBishop1_selected, BlackBishop1_xy, c2c);
            move(pictureBox_blackqueen, BlackQueen_selected, BlackQueen_xy, c2c);
            move(pictureBox_blackking, BlackKing_selected, BlackKing_xy, c2c);
            move(pictureBox_blackbishop2, BlackBishop2_selected, BlackBishop2_xy, c2c);
            move(pictureBox_blackknight2, BlackKnight2_selected, BlackKnight2_xy, c2c);
            move(pictureBox_blackrook2, BlackRook2_selected, BlackRook2_xy, c2c);

            move(pictureBox_whitepawn1, WhitePawn1_selected, WhitePawn1_xy, c2c);
            move(pictureBox_whitepawn2, WhitePawn2_selected, WhitePawn2_xy, c2c);
            move(pictureBox_whitepawn3, WhitePawn3_selected, WhitePawn3_xy, c2c);
            move(pictureBox_whitepawn4, WhitePawn4_selected, WhitePawn4_xy, c2c);
            move(pictureBox_whitepawn5, WhitePawn5_selected, WhitePawn5_xy, c2c);
            move(pictureBox_whitepawn6, WhitePawn6_selected, WhitePawn6_xy, c2c);
            move(pictureBox_whitepawn7, WhitePawn7_selected, WhitePawn7_xy, c2c);
            move(pictureBox_whitepawn8, WhitePawn8_selected, WhitePawn8_xy, c2c);
            move(pictureBox_whiterook1, WhiteRook1_selected, WhiteRook1_xy, c2c);
            move(pictureBox_whiteknight1, WhiteKnight1_selected, WhiteKnight1_xy, c2c);
            move(pictureBox_whitebishop1, WhiteBishop1_selected, WhiteBishop1_xy, c2c);
            move(pictureBox_whitequeen, WhiteQueen_selected, WhiteQueen_xy, c2c);
            move(pictureBox_whiteking, WhiteKing_selected, WhiteKing_xy, c2c);
            move(pictureBox_whitebishop2, WhiteBishop2_selected, WhiteBishop2_xy, c2c);
            move(pictureBox_whiteknight2, WhiteKnight2_selected, WhiteKnight2_xy, c2c);
            move(pictureBox_whiterook2, WhiteRook2_selected, WhiteRook2_xy, c2c);
        }

        private void pictureBox_c3_Click(object sender, EventArgs e)

        {
            move(pictureBox_blackpawn1, BlackPawn1_selected, BlackPawn1_xy, c3c);
            move(pictureBox_blackpawn2, BlackPawn2_selected, BlackPawn2_xy, c3c);
            move(pictureBox_blackpawn3, BlackPawn3_selected, BlackPawn3_xy, c3c);
            move(pictureBox_blackpawn4, BlackPawn4_selected, BlackPawn4_xy, c3c);
            move(pictureBox_blackpawn5, BlackPawn5_selected, BlackPawn5_xy, c3c);
            move(pictureBox_blackpawn6, BlackPawn6_selected, BlackPawn6_xy, c3c);
            move(pictureBox_blackpawn7, BlackPawn7_selected, BlackPawn7_xy, c3c);
            move(pictureBox_blackpawn8, BlackPawn8_selected, BlackPawn8_xy, c3c);
            move(pictureBox_blackrook1, BlackRook1_selected, BlackRook1_xy, c3c);
            move(pictureBox_blackknight1, BlackKnight1_selected, BlackKnight1_xy, c3c);
            move(pictureBox_blackbishop1, BlackBishop1_selected, BlackBishop1_xy, c3c);
            move(pictureBox_blackqueen, BlackQueen_selected, BlackQueen_xy, c3c);
            move(pictureBox_blackking, BlackKing_selected, BlackKing_xy, c3c);
            move(pictureBox_blackbishop2, BlackBishop2_selected, BlackBishop2_xy, c3c);
            move(pictureBox_blackknight2, BlackKnight2_selected, BlackKnight2_xy, c3c);
            move(pictureBox_blackrook2, BlackRook2_selected, BlackRook2_xy, c3c);

            move(pictureBox_whitepawn1, WhitePawn1_selected, WhitePawn1_xy, c3c);
            move(pictureBox_whitepawn2, WhitePawn2_selected, WhitePawn2_xy, c3c);
            move(pictureBox_whitepawn3, WhitePawn3_selected, WhitePawn3_xy, c3c);
            move(pictureBox_whitepawn4, WhitePawn4_selected, WhitePawn4_xy, c3c);
            move(pictureBox_whitepawn5, WhitePawn5_selected, WhitePawn5_xy, c3c);
            move(pictureBox_whitepawn6, WhitePawn6_selected, WhitePawn6_xy, c3c);
            move(pictureBox_whitepawn7, WhitePawn7_selected, WhitePawn7_xy, c3c);
            move(pictureBox_whitepawn8, WhitePawn8_selected, WhitePawn8_xy, c3c);
            move(pictureBox_whiterook1, WhiteRook1_selected, WhiteRook1_xy, c3c);
            move(pictureBox_whiteknight1, WhiteKnight1_selected, WhiteKnight1_xy, c3c);
            move(pictureBox_whitebishop1, WhiteBishop1_selected, WhiteBishop1_xy, c3c);
            move(pictureBox_whitequeen, WhiteQueen_selected, WhiteQueen_xy, c3c);
            move(pictureBox_whiteking, WhiteKing_selected, WhiteKing_xy, c3c);
            move(pictureBox_whitebishop2, WhiteBishop2_selected, WhiteBishop2_xy, c3c);
            move(pictureBox_whiteknight2, WhiteKnight2_selected, WhiteKnight2_xy, c3c);
            move(pictureBox_whiterook2, WhiteRook2_selected, WhiteRook2_xy, c3c);
        }

        private void pictureBox_c4_Click(object sender, EventArgs e)

        {
            move(pictureBox_blackpawn1, BlackPawn1_selected, BlackPawn1_xy, c4c);
            move(pictureBox_blackpawn2, BlackPawn2_selected, BlackPawn2_xy, c4c);
            move(pictureBox_blackpawn3, BlackPawn3_selected, BlackPawn3_xy, c4c);
            move(pictureBox_blackpawn4, BlackPawn4_selected, BlackPawn4_xy, c4c);
            move(pictureBox_blackpawn5, BlackPawn5_selected, BlackPawn5_xy, c4c);
            move(pictureBox_blackpawn6, BlackPawn6_selected, BlackPawn6_xy, c4c);
            move(pictureBox_blackpawn7, BlackPawn7_selected, BlackPawn7_xy, c4c);
            move(pictureBox_blackpawn8, BlackPawn8_selected, BlackPawn8_xy, c4c);
            move(pictureBox_blackrook1, BlackRook1_selected, BlackRook1_xy, c4c);
            move(pictureBox_blackknight1, BlackKnight1_selected, BlackKnight1_xy, c4c);
            move(pictureBox_blackbishop1, BlackBishop1_selected, BlackBishop1_xy, c4c);
            move(pictureBox_blackqueen, BlackQueen_selected, BlackQueen_xy, c4c);
            move(pictureBox_blackking, BlackKing_selected, BlackKing_xy, c4c);
            move(pictureBox_blackbishop2, BlackBishop2_selected, BlackBishop2_xy, c4c);
            move(pictureBox_blackknight2, BlackKnight2_selected, BlackKnight2_xy, c4c);
            move(pictureBox_blackrook2, BlackRook2_selected, BlackRook2_xy, c4c);

            move(pictureBox_whitepawn1, WhitePawn1_selected, WhitePawn1_xy, c4c);
            move(pictureBox_whitepawn2, WhitePawn2_selected, WhitePawn2_xy, c4c);
            move(pictureBox_whitepawn3, WhitePawn3_selected, WhitePawn3_xy, c4c);
            move(pictureBox_whitepawn4, WhitePawn4_selected, WhitePawn4_xy, c4c);
            move(pictureBox_whitepawn5, WhitePawn5_selected, WhitePawn5_xy, c4c);
            move(pictureBox_whitepawn6, WhitePawn6_selected, WhitePawn6_xy, c4c);
            move(pictureBox_whitepawn7, WhitePawn7_selected, WhitePawn7_xy, c4c);
            move(pictureBox_whitepawn8, WhitePawn8_selected, WhitePawn8_xy, c4c);
            move(pictureBox_whiterook1, WhiteRook1_selected, WhiteRook1_xy, c4c);
            move(pictureBox_whiteknight1, WhiteKnight1_selected, WhiteKnight1_xy, c4c);
            move(pictureBox_whitebishop1, WhiteBishop1_selected, WhiteBishop1_xy, c4c);
            move(pictureBox_whitequeen, WhiteQueen_selected, WhiteQueen_xy, c4c);
            move(pictureBox_whiteking, WhiteKing_selected, WhiteKing_xy, c4c);
            move(pictureBox_whitebishop2, WhiteBishop2_selected, WhiteBishop2_xy, c4c);
            move(pictureBox_whiteknight2, WhiteKnight2_selected, WhiteKnight2_xy, c4c);
            move(pictureBox_whiterook2, WhiteRook2_selected, WhiteRook2_xy, c4c);
        }

        private void pictureBox_c5_Click(object sender, EventArgs e)

        {
            move(pictureBox_blackpawn1, BlackPawn1_selected, BlackPawn1_xy, c5c);
            move(pictureBox_blackpawn2, BlackPawn2_selected, BlackPawn2_xy, c5c);
            move(pictureBox_blackpawn3, BlackPawn3_selected, BlackPawn3_xy, c5c);
            move(pictureBox_blackpawn4, BlackPawn4_selected, BlackPawn4_xy, c5c);
            move(pictureBox_blackpawn5, BlackPawn5_selected, BlackPawn5_xy, c5c);
            move(pictureBox_blackpawn6, BlackPawn6_selected, BlackPawn6_xy, c5c);
            move(pictureBox_blackpawn7, BlackPawn7_selected, BlackPawn7_xy, c5c);
            move(pictureBox_blackpawn8, BlackPawn8_selected, BlackPawn8_xy, c5c);
            move(pictureBox_blackrook1, BlackRook1_selected, BlackRook1_xy, c5c);
            move(pictureBox_blackknight1, BlackKnight1_selected, BlackKnight1_xy, c5c);
            move(pictureBox_blackbishop1, BlackBishop1_selected, BlackBishop1_xy, c5c);
            move(pictureBox_blackqueen, BlackQueen_selected, BlackQueen_xy, c5c);
            move(pictureBox_blackking, BlackKing_selected, BlackKing_xy, c5c);
            move(pictureBox_blackbishop2, BlackBishop2_selected, BlackBishop2_xy, c5c);
            move(pictureBox_blackknight2, BlackKnight2_selected, BlackKnight2_xy, c5c);
            move(pictureBox_blackrook2, BlackRook2_selected, BlackRook2_xy, c5c);

            move(pictureBox_whitepawn1, WhitePawn1_selected, WhitePawn1_xy, c5c);
            move(pictureBox_whitepawn2, WhitePawn2_selected, WhitePawn2_xy, c5c);
            move(pictureBox_whitepawn3, WhitePawn3_selected, WhitePawn3_xy, c5c);
            move(pictureBox_whitepawn4, WhitePawn4_selected, WhitePawn4_xy, c5c);
            move(pictureBox_whitepawn5, WhitePawn5_selected, WhitePawn5_xy, c5c);
            move(pictureBox_whitepawn6, WhitePawn6_selected, WhitePawn6_xy, c5c);
            move(pictureBox_whitepawn7, WhitePawn7_selected, WhitePawn7_xy, c5c);
            move(pictureBox_whitepawn8, WhitePawn8_selected, WhitePawn8_xy, c5c);
            move(pictureBox_whiterook1, WhiteRook1_selected, WhiteRook1_xy, c5c);
            move(pictureBox_whiteknight1, WhiteKnight1_selected, WhiteKnight1_xy, c5c);
            move(pictureBox_whitebishop1, WhiteBishop1_selected, WhiteBishop1_xy, c5c);
            move(pictureBox_whitequeen, WhiteQueen_selected, WhiteQueen_xy, c5c);
            move(pictureBox_whiteking, WhiteKing_selected, WhiteKing_xy, c5c);
            move(pictureBox_whitebishop2, WhiteBishop2_selected, WhiteBishop2_xy, c5c);
            move(pictureBox_whiteknight2, WhiteKnight2_selected, WhiteKnight2_xy, c5c);
            move(pictureBox_whiterook2, WhiteRook2_selected, WhiteRook2_xy, c5c);
        }

        private void pictureBox_c6_Click(object sender, EventArgs e)

        {
            move(pictureBox_blackpawn1, BlackPawn1_selected, BlackPawn1_xy, c6c);
            move(pictureBox_blackpawn2, BlackPawn2_selected, BlackPawn2_xy, c6c);
            move(pictureBox_blackpawn3, BlackPawn3_selected, BlackPawn3_xy, c6c);
            move(pictureBox_blackpawn4, BlackPawn4_selected, BlackPawn4_xy, c6c);
            move(pictureBox_blackpawn5, BlackPawn5_selected, BlackPawn5_xy, c6c);
            move(pictureBox_blackpawn6, BlackPawn6_selected, BlackPawn6_xy, c6c);
            move(pictureBox_blackpawn7, BlackPawn7_selected, BlackPawn7_xy, c6c);
            move(pictureBox_blackpawn8, BlackPawn8_selected, BlackPawn8_xy, c6c);
            move(pictureBox_blackrook1, BlackRook1_selected, BlackRook1_xy, c6c);
            move(pictureBox_blackknight1, BlackKnight1_selected, BlackKnight1_xy, c6c);
            move(pictureBox_blackbishop1, BlackBishop1_selected, BlackBishop1_xy, c6c);
            move(pictureBox_blackqueen, BlackQueen_selected, BlackQueen_xy, c6c);
            move(pictureBox_blackking, BlackKing_selected, BlackKing_xy, c6c);
            move(pictureBox_blackbishop2, BlackBishop2_selected, BlackBishop2_xy, c6c);
            move(pictureBox_blackknight2, BlackKnight2_selected, BlackKnight2_xy, c6c);
            move(pictureBox_blackrook2, BlackRook2_selected, BlackRook2_xy, c6c);

            move(pictureBox_whitepawn1, WhitePawn1_selected, WhitePawn1_xy, c6c);
            move(pictureBox_whitepawn2, WhitePawn2_selected, WhitePawn2_xy, c6c);
            move(pictureBox_whitepawn3, WhitePawn3_selected, WhitePawn3_xy, c6c);
            move(pictureBox_whitepawn4, WhitePawn4_selected, WhitePawn4_xy, c6c);
            move(pictureBox_whitepawn5, WhitePawn5_selected, WhitePawn5_xy, c6c);
            move(pictureBox_whitepawn6, WhitePawn6_selected, WhitePawn6_xy, c6c);
            move(pictureBox_whitepawn7, WhitePawn7_selected, WhitePawn7_xy, c6c);
            move(pictureBox_whitepawn8, WhitePawn8_selected, WhitePawn8_xy, c6c);
            move(pictureBox_whiterook1, WhiteRook1_selected, WhiteRook1_xy, c6c);
            move(pictureBox_whiteknight1, WhiteKnight1_selected, WhiteKnight1_xy, c6c);
            move(pictureBox_whitebishop1, WhiteBishop1_selected, WhiteBishop1_xy, c6c);
            move(pictureBox_whitequeen, WhiteQueen_selected, WhiteQueen_xy, c6c);
            move(pictureBox_whiteking, WhiteKing_selected, WhiteKing_xy, c6c);
            move(pictureBox_whitebishop2, WhiteBishop2_selected, WhiteBishop2_xy, c6c);
            move(pictureBox_whiteknight2, WhiteKnight2_selected, WhiteKnight2_xy, c6c);
            move(pictureBox_whiterook2, WhiteRook2_selected, WhiteRook2_xy, c6c);
        }

        private void pictureBox_c7_Click(object sender, EventArgs e)

        {
            move(pictureBox_blackpawn1, BlackPawn1_selected, BlackPawn1_xy, c7c);
            move(pictureBox_blackpawn2, BlackPawn2_selected, BlackPawn2_xy, c7c);
            move(pictureBox_blackpawn3, BlackPawn3_selected, BlackPawn3_xy, c7c);
            move(pictureBox_blackpawn4, BlackPawn4_selected, BlackPawn4_xy, c7c);
            move(pictureBox_blackpawn5, BlackPawn5_selected, BlackPawn5_xy, c7c);
            move(pictureBox_blackpawn6, BlackPawn6_selected, BlackPawn6_xy, c7c);
            move(pictureBox_blackpawn7, BlackPawn7_selected, BlackPawn7_xy, c7c);
            move(pictureBox_blackpawn8, BlackPawn8_selected, BlackPawn8_xy, c7c);
            move(pictureBox_blackrook1, BlackRook1_selected, BlackRook1_xy, c7c);
            move(pictureBox_blackknight1, BlackKnight1_selected, BlackKnight1_xy, c7c);
            move(pictureBox_blackbishop1, BlackBishop1_selected, BlackBishop1_xy, c7c);
            move(pictureBox_blackqueen, BlackQueen_selected, BlackQueen_xy, c7c);
            move(pictureBox_blackking, BlackKing_selected, BlackKing_xy, c7c);
            move(pictureBox_blackbishop2, BlackBishop2_selected, BlackBishop2_xy, c7c);
            move(pictureBox_blackknight2, BlackKnight2_selected, BlackKnight2_xy, c7c);
            move(pictureBox_blackrook2, BlackRook2_selected, BlackRook2_xy, c7c);

            move(pictureBox_whitepawn1, WhitePawn1_selected, WhitePawn1_xy, c7c);
            move(pictureBox_whitepawn2, WhitePawn2_selected, WhitePawn2_xy, c7c);
            move(pictureBox_whitepawn3, WhitePawn3_selected, WhitePawn3_xy, c7c);
            move(pictureBox_whitepawn4, WhitePawn4_selected, WhitePawn4_xy, c7c);
            move(pictureBox_whitepawn5, WhitePawn5_selected, WhitePawn5_xy, c7c);
            move(pictureBox_whitepawn6, WhitePawn6_selected, WhitePawn6_xy, c7c);
            move(pictureBox_whitepawn7, WhitePawn7_selected, WhitePawn7_xy, c7c);
            move(pictureBox_whitepawn8, WhitePawn8_selected, WhitePawn8_xy, c7c);
            move(pictureBox_whiterook1, WhiteRook1_selected, WhiteRook1_xy, c7c);
            move(pictureBox_whiteknight1, WhiteKnight1_selected, WhiteKnight1_xy, c7c);
            move(pictureBox_whitebishop1, WhiteBishop1_selected, WhiteBishop1_xy, c7c);
            move(pictureBox_whitequeen, WhiteQueen_selected, WhiteQueen_xy, c7c);
            move(pictureBox_whiteking, WhiteKing_selected, WhiteKing_xy, c7c);
            move(pictureBox_whitebishop2, WhiteBishop2_selected, WhiteBishop2_xy, c7c);
            move(pictureBox_whiteknight2, WhiteKnight2_selected, WhiteKnight2_xy, c7c);
            move(pictureBox_whiterook2, WhiteRook2_selected, WhiteRook2_xy, c7c);
        }

        private void pictureBox_c8_Click(object sender, EventArgs e)

        {
            move(pictureBox_blackpawn1, BlackPawn1_selected, BlackPawn1_xy, c8c);
            move(pictureBox_blackpawn2, BlackPawn2_selected, BlackPawn2_xy, c8c);
            move(pictureBox_blackpawn3, BlackPawn3_selected, BlackPawn3_xy, c8c);
            move(pictureBox_blackpawn4, BlackPawn4_selected, BlackPawn4_xy, c8c);
            move(pictureBox_blackpawn5, BlackPawn5_selected, BlackPawn5_xy, c8c);
            move(pictureBox_blackpawn6, BlackPawn6_selected, BlackPawn6_xy, c8c);
            move(pictureBox_blackpawn7, BlackPawn7_selected, BlackPawn7_xy, c8c);
            move(pictureBox_blackpawn8, BlackPawn8_selected, BlackPawn8_xy, c8c);
            move(pictureBox_blackrook1, BlackRook1_selected, BlackRook1_xy, c8c);
            move(pictureBox_blackknight1, BlackKnight1_selected, BlackKnight1_xy, c8c);
            move(pictureBox_blackbishop1, BlackBishop1_selected, BlackBishop1_xy, c8c);
            move(pictureBox_blackqueen, BlackQueen_selected, BlackQueen_xy, c8c);
            move(pictureBox_blackking, BlackKing_selected, BlackKing_xy, c8c);
            move(pictureBox_blackbishop2, BlackBishop2_selected, BlackBishop2_xy, c8c);
            move(pictureBox_blackknight2, BlackKnight2_selected, BlackKnight2_xy, c8c);
            move(pictureBox_blackrook2, BlackRook2_selected, BlackRook2_xy, c8c);

            move(pictureBox_whitepawn1, WhitePawn1_selected, WhitePawn1_xy, c8c);
            move(pictureBox_whitepawn2, WhitePawn2_selected, WhitePawn2_xy, c8c);
            move(pictureBox_whitepawn3, WhitePawn3_selected, WhitePawn3_xy, c8c);
            move(pictureBox_whitepawn4, WhitePawn4_selected, WhitePawn4_xy, c8c);
            move(pictureBox_whitepawn5, WhitePawn5_selected, WhitePawn5_xy, c8c);
            move(pictureBox_whitepawn6, WhitePawn6_selected, WhitePawn6_xy, c8c);
            move(pictureBox_whitepawn7, WhitePawn7_selected, WhitePawn7_xy, c8c);
            move(pictureBox_whitepawn8, WhitePawn8_selected, WhitePawn8_xy, c8c);
            move(pictureBox_whiterook1, WhiteRook1_selected, WhiteRook1_xy, c8c);
            move(pictureBox_whiteknight1, WhiteKnight1_selected, WhiteKnight1_xy, c8c);
            move(pictureBox_whitebishop1, WhiteBishop1_selected, WhiteBishop1_xy, c8c);
            move(pictureBox_whitequeen, WhiteQueen_selected, WhiteQueen_xy, c8c);
            move(pictureBox_whiteking, WhiteKing_selected, WhiteKing_xy, c8c);
            move(pictureBox_whitebishop2, WhiteBishop2_selected, WhiteBishop2_xy, c8c);
            move(pictureBox_whiteknight2, WhiteKnight2_selected, WhiteKnight2_xy, c8c);
            move(pictureBox_whiterook2, WhiteRook2_selected, WhiteRook2_xy, c8c);
        }


        private void pictureBox_d1_Click(object sender, EventArgs e)

        {
            move(pictureBox_blackpawn1, BlackPawn1_selected, BlackPawn1_xy, d1c);
            move(pictureBox_blackpawn2, BlackPawn2_selected, BlackPawn2_xy, d1c);
            move(pictureBox_blackpawn3, BlackPawn3_selected, BlackPawn3_xy, d1c);
            move(pictureBox_blackpawn4, BlackPawn4_selected, BlackPawn4_xy, d1c);
            move(pictureBox_blackpawn5, BlackPawn5_selected, BlackPawn5_xy, d1c);
            move(pictureBox_blackpawn6, BlackPawn6_selected, BlackPawn6_xy, d1c);
            move(pictureBox_blackpawn7, BlackPawn7_selected, BlackPawn7_xy, d1c);
            move(pictureBox_blackpawn8, BlackPawn8_selected, BlackPawn8_xy, d1c);
            move(pictureBox_blackrook1, BlackRook1_selected, BlackRook1_xy, d1c);
            move(pictureBox_blackknight1, BlackKnight1_selected, BlackKnight1_xy, d1c);
            move(pictureBox_blackbishop1, BlackBishop1_selected, BlackBishop1_xy, d1c);
            move(pictureBox_blackqueen, BlackQueen_selected, BlackQueen_xy, d1c);
            move(pictureBox_blackking, BlackKing_selected, BlackKing_xy, d1c);
            move(pictureBox_blackbishop2, BlackBishop2_selected, BlackBishop2_xy, d1c);
            move(pictureBox_blackknight2, BlackKnight2_selected, BlackKnight2_xy, d1c);
            move(pictureBox_blackrook2, BlackRook2_selected, BlackRook2_xy, d1c);

            move(pictureBox_whitepawn1, WhitePawn1_selected, WhitePawn1_xy, d1c);
            move(pictureBox_whitepawn2, WhitePawn2_selected, WhitePawn2_xy, d1c);
            move(pictureBox_whitepawn3, WhitePawn3_selected, WhitePawn3_xy, d1c);
            move(pictureBox_whitepawn4, WhitePawn4_selected, WhitePawn4_xy, d1c);
            move(pictureBox_whitepawn5, WhitePawn5_selected, WhitePawn5_xy, d1c);
            move(pictureBox_whitepawn6, WhitePawn6_selected, WhitePawn6_xy, d1c);
            move(pictureBox_whitepawn7, WhitePawn7_selected, WhitePawn7_xy, d1c);
            move(pictureBox_whitepawn8, WhitePawn8_selected, WhitePawn8_xy, d1c);
            move(pictureBox_whiterook1, WhiteRook1_selected, WhiteRook1_xy, d1c);
            move(pictureBox_whiteknight1, WhiteKnight1_selected, WhiteKnight1_xy, d1c);
            move(pictureBox_whitebishop1, WhiteBishop1_selected, WhiteBishop1_xy, d1c);
            move(pictureBox_whitequeen, WhiteQueen_selected, WhiteQueen_xy, d1c);
            move(pictureBox_whiteking, WhiteKing_selected, WhiteKing_xy, d1c);
            move(pictureBox_whitebishop2, WhiteBishop2_selected, WhiteBishop2_xy, d1c);
            move(pictureBox_whiteknight2, WhiteKnight2_selected, WhiteKnight2_xy, d1c);
            move(pictureBox_whiterook2, WhiteRook2_selected, WhiteRook2_xy, d1c);
        }

        private void pictureBox_d2_Click(object sender, EventArgs e)

        {
            move(pictureBox_blackpawn1, BlackPawn1_selected, BlackPawn1_xy, d2c);
            move(pictureBox_blackpawn2, BlackPawn2_selected, BlackPawn2_xy, d2c);
            move(pictureBox_blackpawn3, BlackPawn3_selected, BlackPawn3_xy, d2c);
            move(pictureBox_blackpawn4, BlackPawn4_selected, BlackPawn4_xy, d2c);
            move(pictureBox_blackpawn5, BlackPawn5_selected, BlackPawn5_xy, d2c);
            move(pictureBox_blackpawn6, BlackPawn6_selected, BlackPawn6_xy, d2c);
            move(pictureBox_blackpawn7, BlackPawn7_selected, BlackPawn7_xy, d2c);
            move(pictureBox_blackpawn8, BlackPawn8_selected, BlackPawn8_xy, d2c);
            move(pictureBox_blackrook1, BlackRook1_selected, BlackRook1_xy, d2c);
            move(pictureBox_blackknight1, BlackKnight1_selected, BlackKnight1_xy, d2c);
            move(pictureBox_blackbishop1, BlackBishop1_selected, BlackBishop1_xy, d2c);
            move(pictureBox_blackqueen, BlackQueen_selected, BlackQueen_xy, d2c);
            move(pictureBox_blackking, BlackKing_selected, BlackKing_xy, d2c);
            move(pictureBox_blackbishop2, BlackBishop2_selected, BlackBishop2_xy, d2c);
            move(pictureBox_blackknight2, BlackKnight2_selected, BlackKnight2_xy, d2c);
            move(pictureBox_blackrook2, BlackRook2_selected, BlackRook2_xy, d2c);

            move(pictureBox_whitepawn1, WhitePawn1_selected, WhitePawn1_xy, d2c);
            move(pictureBox_whitepawn2, WhitePawn2_selected, WhitePawn2_xy, d2c);
            move(pictureBox_whitepawn3, WhitePawn3_selected, WhitePawn3_xy, d2c);
            move(pictureBox_whitepawn4, WhitePawn4_selected, WhitePawn4_xy, d2c);
            move(pictureBox_whitepawn5, WhitePawn5_selected, WhitePawn5_xy, d2c);
            move(pictureBox_whitepawn6, WhitePawn6_selected, WhitePawn6_xy, d2c);
            move(pictureBox_whitepawn7, WhitePawn7_selected, WhitePawn7_xy, d2c);
            move(pictureBox_whitepawn8, WhitePawn8_selected, WhitePawn8_xy, d2c);
            move(pictureBox_whiterook1, WhiteRook1_selected, WhiteRook1_xy, d2c);
            move(pictureBox_whiteknight1, WhiteKnight1_selected, WhiteKnight1_xy, d2c);
            move(pictureBox_whitebishop1, WhiteBishop1_selected, WhiteBishop1_xy, d2c);
            move(pictureBox_whitequeen, WhiteQueen_selected, WhiteQueen_xy, d2c);
            move(pictureBox_whiteking, WhiteKing_selected, WhiteKing_xy, d2c);
            move(pictureBox_whitebishop2, WhiteBishop2_selected, WhiteBishop2_xy, d2c);
            move(pictureBox_whiteknight2, WhiteKnight2_selected, WhiteKnight2_xy, d2c);
            move(pictureBox_whiterook2, WhiteRook2_selected, WhiteRook2_xy, d2c);
        }

        private void pictureBox_d3_Click(object sender, EventArgs e)

        {
            move(pictureBox_blackpawn1, BlackPawn1_selected, BlackPawn1_xy, d3c);
            move(pictureBox_blackpawn2, BlackPawn2_selected, BlackPawn2_xy, d3c);
            move(pictureBox_blackpawn3, BlackPawn3_selected, BlackPawn3_xy, d3c);
            move(pictureBox_blackpawn4, BlackPawn4_selected, BlackPawn4_xy, d3c);
            move(pictureBox_blackpawn5, BlackPawn5_selected, BlackPawn5_xy, d3c);
            move(pictureBox_blackpawn6, BlackPawn6_selected, BlackPawn6_xy, d3c);
            move(pictureBox_blackpawn7, BlackPawn7_selected, BlackPawn7_xy, d3c);
            move(pictureBox_blackpawn8, BlackPawn8_selected, BlackPawn8_xy, d3c);
            move(pictureBox_blackrook1, BlackRook1_selected, BlackRook1_xy, d3c);
            move(pictureBox_blackknight1, BlackKnight1_selected, BlackKnight1_xy, d3c);
            move(pictureBox_blackbishop1, BlackBishop1_selected, BlackBishop1_xy, d3c);
            move(pictureBox_blackqueen, BlackQueen_selected, BlackQueen_xy, d3c);
            move(pictureBox_blackking, BlackKing_selected, BlackKing_xy, d3c);
            move(pictureBox_blackbishop2, BlackBishop2_selected, BlackBishop2_xy, d3c);
            move(pictureBox_blackknight2, BlackKnight2_selected, BlackKnight2_xy, d3c);
            move(pictureBox_blackrook2, BlackRook2_selected, BlackRook2_xy, d3c);

            move(pictureBox_whitepawn1, WhitePawn1_selected, WhitePawn1_xy, d3c);
            move(pictureBox_whitepawn2, WhitePawn2_selected, WhitePawn2_xy, d3c);
            move(pictureBox_whitepawn3, WhitePawn3_selected, WhitePawn3_xy, d3c);
            move(pictureBox_whitepawn4, WhitePawn4_selected, WhitePawn4_xy, d3c);
            move(pictureBox_whitepawn5, WhitePawn5_selected, WhitePawn5_xy, d3c);
            move(pictureBox_whitepawn6, WhitePawn6_selected, WhitePawn6_xy, d3c);
            move(pictureBox_whitepawn7, WhitePawn7_selected, WhitePawn7_xy, d3c);
            move(pictureBox_whitepawn8, WhitePawn8_selected, WhitePawn8_xy, d3c);
            move(pictureBox_whiterook1, WhiteRook1_selected, WhiteRook1_xy, d3c);
            move(pictureBox_whiteknight1, WhiteKnight1_selected, WhiteKnight1_xy, d3c);
            move(pictureBox_whitebishop1, WhiteBishop1_selected, WhiteBishop1_xy, d3c);
            move(pictureBox_whitequeen, WhiteQueen_selected, WhiteQueen_xy, d3c);
            move(pictureBox_whiteking, WhiteKing_selected, WhiteKing_xy, d3c);
            move(pictureBox_whitebishop2, WhiteBishop2_selected, WhiteBishop2_xy, d3c);
            move(pictureBox_whiteknight2, WhiteKnight2_selected, WhiteKnight2_xy, d3c);
            move(pictureBox_whiterook2, WhiteRook2_selected, WhiteRook2_xy, d3c);
        }

        private void pictureBox_d4_Click(object sender, EventArgs e)

        {
            move(pictureBox_blackpawn1, BlackPawn1_selected, BlackPawn1_xy, d4c);
            move(pictureBox_blackpawn2, BlackPawn2_selected, BlackPawn2_xy, d4c);
            move(pictureBox_blackpawn3, BlackPawn3_selected, BlackPawn3_xy, d4c);
            move(pictureBox_blackpawn4, BlackPawn4_selected, BlackPawn4_xy, d4c);
            move(pictureBox_blackpawn5, BlackPawn5_selected, BlackPawn5_xy, d4c);
            move(pictureBox_blackpawn6, BlackPawn6_selected, BlackPawn6_xy, d4c);
            move(pictureBox_blackpawn7, BlackPawn7_selected, BlackPawn7_xy, d4c);
            move(pictureBox_blackpawn8, BlackPawn8_selected, BlackPawn8_xy, d4c);
            move(pictureBox_blackrook1, BlackRook1_selected, BlackRook1_xy, d4c);
            move(pictureBox_blackknight1, BlackKnight1_selected, BlackKnight1_xy, d4c);
            move(pictureBox_blackbishop1, BlackBishop1_selected, BlackBishop1_xy, d4c);
            move(pictureBox_blackqueen, BlackQueen_selected, BlackQueen_xy, d4c);
            move(pictureBox_blackking, BlackKing_selected, BlackKing_xy, d4c);
            move(pictureBox_blackbishop2, BlackBishop2_selected, BlackBishop2_xy, d4c);
            move(pictureBox_blackknight2, BlackKnight2_selected, BlackKnight2_xy, d4c);
            move(pictureBox_blackrook2, BlackRook2_selected, BlackRook2_xy, d4c);

            move(pictureBox_whitepawn1, WhitePawn1_selected, WhitePawn1_xy, d4c);
            move(pictureBox_whitepawn2, WhitePawn2_selected, WhitePawn2_xy, d4c);
            move(pictureBox_whitepawn3, WhitePawn3_selected, WhitePawn3_xy, d4c);
            move(pictureBox_whitepawn4, WhitePawn4_selected, WhitePawn4_xy, d4c);
            move(pictureBox_whitepawn5, WhitePawn5_selected, WhitePawn5_xy, d4c);
            move(pictureBox_whitepawn6, WhitePawn6_selected, WhitePawn6_xy, d4c);
            move(pictureBox_whitepawn7, WhitePawn7_selected, WhitePawn7_xy, d4c);
            move(pictureBox_whitepawn8, WhitePawn8_selected, WhitePawn8_xy, d4c);
            move(pictureBox_whiterook1, WhiteRook1_selected, WhiteRook1_xy, d4c);
            move(pictureBox_whiteknight1, WhiteKnight1_selected, WhiteKnight1_xy, d4c);
            move(pictureBox_whitebishop1, WhiteBishop1_selected, WhiteBishop1_xy, d4c);
            move(pictureBox_whitequeen, WhiteQueen_selected, WhiteQueen_xy, d4c);
            move(pictureBox_whiteking, WhiteKing_selected, WhiteKing_xy, d4c);
            move(pictureBox_whitebishop2, WhiteBishop2_selected, WhiteBishop2_xy, d4c);
            move(pictureBox_whiteknight2, WhiteKnight2_selected, WhiteKnight2_xy, d4c);
            move(pictureBox_whiterook2, WhiteRook2_selected, WhiteRook2_xy, d4c);
        }

        private void pictureBox_d5_Click(object sender, EventArgs e)

        {
            move(pictureBox_blackpawn1, BlackPawn1_selected, BlackPawn1_xy, d5c);
            move(pictureBox_blackpawn2, BlackPawn2_selected, BlackPawn2_xy, d5c);
            move(pictureBox_blackpawn3, BlackPawn3_selected, BlackPawn3_xy, d5c);
            move(pictureBox_blackpawn4, BlackPawn4_selected, BlackPawn4_xy, d5c);
            move(pictureBox_blackpawn5, BlackPawn5_selected, BlackPawn5_xy, d5c);
            move(pictureBox_blackpawn6, BlackPawn6_selected, BlackPawn6_xy, d5c);
            move(pictureBox_blackpawn7, BlackPawn7_selected, BlackPawn7_xy, d5c);
            move(pictureBox_blackpawn8, BlackPawn8_selected, BlackPawn8_xy, d5c);
            move(pictureBox_blackrook1, BlackRook1_selected, BlackRook1_xy, d5c);
            move(pictureBox_blackknight1, BlackKnight1_selected, BlackKnight1_xy, d5c);
            move(pictureBox_blackbishop1, BlackBishop1_selected, BlackBishop1_xy, d5c);
            move(pictureBox_blackqueen, BlackQueen_selected, BlackQueen_xy, d5c);
            move(pictureBox_blackking, BlackKing_selected, BlackKing_xy, d5c);
            move(pictureBox_blackbishop2, BlackBishop2_selected, BlackBishop2_xy, d5c);
            move(pictureBox_blackknight2, BlackKnight2_selected, BlackKnight2_xy, d5c);
            move(pictureBox_blackrook2, BlackRook2_selected, BlackRook2_xy, d5c);

            move(pictureBox_whitepawn1, WhitePawn1_selected, WhitePawn1_xy, d5c);
            move(pictureBox_whitepawn2, WhitePawn2_selected, WhitePawn2_xy, d5c);
            move(pictureBox_whitepawn3, WhitePawn3_selected, WhitePawn3_xy, d5c);
            move(pictureBox_whitepawn4, WhitePawn4_selected, WhitePawn4_xy, d5c);
            move(pictureBox_whitepawn5, WhitePawn5_selected, WhitePawn5_xy, d5c);
            move(pictureBox_whitepawn6, WhitePawn6_selected, WhitePawn6_xy, d5c);
            move(pictureBox_whitepawn7, WhitePawn7_selected, WhitePawn7_xy, d5c);
            move(pictureBox_whitepawn8, WhitePawn8_selected, WhitePawn8_xy, d5c);
            move(pictureBox_whiterook1, WhiteRook1_selected, WhiteRook1_xy, d5c);
            move(pictureBox_whiteknight1, WhiteKnight1_selected, WhiteKnight1_xy, d5c);
            move(pictureBox_whitebishop1, WhiteBishop1_selected, WhiteBishop1_xy, d5c);
            move(pictureBox_whitequeen, WhiteQueen_selected, WhiteQueen_xy, d5c);
            move(pictureBox_whiteking, WhiteKing_selected, WhiteKing_xy, d5c);
            move(pictureBox_whitebishop2, WhiteBishop2_selected, WhiteBishop2_xy, d5c);
            move(pictureBox_whiteknight2, WhiteKnight2_selected, WhiteKnight2_xy, d5c);
            move(pictureBox_whiterook2, WhiteRook2_selected, WhiteRook2_xy, d5c);
        }

        private void pictureBox_d6_Click(object sender, EventArgs e)

        {
            move(pictureBox_blackpawn1, BlackPawn1_selected, BlackPawn1_xy, d6c);
            move(pictureBox_blackpawn2, BlackPawn2_selected, BlackPawn2_xy, d6c);
            move(pictureBox_blackpawn3, BlackPawn3_selected, BlackPawn3_xy, d6c);
            move(pictureBox_blackpawn4, BlackPawn4_selected, BlackPawn4_xy, d6c);
            move(pictureBox_blackpawn5, BlackPawn5_selected, BlackPawn5_xy, d6c);
            move(pictureBox_blackpawn6, BlackPawn6_selected, BlackPawn6_xy, d6c);
            move(pictureBox_blackpawn7, BlackPawn7_selected, BlackPawn7_xy, d6c);
            move(pictureBox_blackpawn8, BlackPawn8_selected, BlackPawn8_xy, d6c);
            move(pictureBox_blackrook1, BlackRook1_selected, BlackRook1_xy, d6c);
            move(pictureBox_blackknight1, BlackKnight1_selected, BlackKnight1_xy, d6c);
            move(pictureBox_blackbishop1, BlackBishop1_selected, BlackBishop1_xy, d6c);
            move(pictureBox_blackqueen, BlackQueen_selected, BlackQueen_xy, d6c);
            move(pictureBox_blackking, BlackKing_selected, BlackKing_xy, d6c);
            move(pictureBox_blackbishop2, BlackBishop2_selected, BlackBishop2_xy, d6c);
            move(pictureBox_blackknight2, BlackKnight2_selected, BlackKnight2_xy, d6c);
            move(pictureBox_blackrook2, BlackRook2_selected, BlackRook2_xy, d6c);

            move(pictureBox_whitepawn1, WhitePawn1_selected, WhitePawn1_xy, d6c);
            move(pictureBox_whitepawn2, WhitePawn2_selected, WhitePawn2_xy, d6c);
            move(pictureBox_whitepawn3, WhitePawn3_selected, WhitePawn3_xy, d6c);
            move(pictureBox_whitepawn4, WhitePawn4_selected, WhitePawn4_xy, d6c);
            move(pictureBox_whitepawn5, WhitePawn5_selected, WhitePawn5_xy, d6c);
            move(pictureBox_whitepawn6, WhitePawn6_selected, WhitePawn6_xy, d6c);
            move(pictureBox_whitepawn7, WhitePawn7_selected, WhitePawn7_xy, d6c);
            move(pictureBox_whitepawn8, WhitePawn8_selected, WhitePawn8_xy, d6c);
            move(pictureBox_whiterook1, WhiteRook1_selected, WhiteRook1_xy, d6c);
            move(pictureBox_whiteknight1, WhiteKnight1_selected, WhiteKnight1_xy, d6c);
            move(pictureBox_whitebishop1, WhiteBishop1_selected, WhiteBishop1_xy, d6c);
            move(pictureBox_whitequeen, WhiteQueen_selected, WhiteQueen_xy, d6c);
            move(pictureBox_whiteking, WhiteKing_selected, WhiteKing_xy, d6c);
            move(pictureBox_whitebishop2, WhiteBishop2_selected, WhiteBishop2_xy, d6c);
            move(pictureBox_whiteknight2, WhiteKnight2_selected, WhiteKnight2_xy, d6c);
            move(pictureBox_whiterook2, WhiteRook2_selected, WhiteRook2_xy, d6c);
        }

        private void pictureBox_d7_Click(object sender, EventArgs e)

        {
            move(pictureBox_blackpawn1, BlackPawn1_selected, BlackPawn1_xy, d7c);
            move(pictureBox_blackpawn2, BlackPawn2_selected, BlackPawn2_xy, d7c);
            move(pictureBox_blackpawn3, BlackPawn3_selected, BlackPawn3_xy, d7c);
            move(pictureBox_blackpawn4, BlackPawn4_selected, BlackPawn4_xy, d7c);
            move(pictureBox_blackpawn5, BlackPawn5_selected, BlackPawn5_xy, d7c);
            move(pictureBox_blackpawn6, BlackPawn6_selected, BlackPawn6_xy, d7c);
            move(pictureBox_blackpawn7, BlackPawn7_selected, BlackPawn7_xy, d7c);
            move(pictureBox_blackpawn8, BlackPawn8_selected, BlackPawn8_xy, d7c);
            move(pictureBox_blackrook1, BlackRook1_selected, BlackRook1_xy, d7c);
            move(pictureBox_blackknight1, BlackKnight1_selected, BlackKnight1_xy, d7c);
            move(pictureBox_blackbishop1, BlackBishop1_selected, BlackBishop1_xy, d7c);
            move(pictureBox_blackqueen, BlackQueen_selected, BlackQueen_xy, d7c);
            move(pictureBox_blackking, BlackKing_selected, BlackKing_xy, d7c);
            move(pictureBox_blackbishop2, BlackBishop2_selected, BlackBishop2_xy, d7c);
            move(pictureBox_blackknight2, BlackKnight2_selected, BlackKnight2_xy, d7c);
            move(pictureBox_blackrook2, BlackRook2_selected, BlackRook2_xy, d7c);

            move(pictureBox_whitepawn1, WhitePawn1_selected, WhitePawn1_xy, d7c);
            move(pictureBox_whitepawn2, WhitePawn2_selected, WhitePawn2_xy, d7c);
            move(pictureBox_whitepawn3, WhitePawn3_selected, WhitePawn3_xy, d7c);
            move(pictureBox_whitepawn4, WhitePawn4_selected, WhitePawn4_xy, d7c);
            move(pictureBox_whitepawn5, WhitePawn5_selected, WhitePawn5_xy, d7c);
            move(pictureBox_whitepawn6, WhitePawn6_selected, WhitePawn6_xy, d7c);
            move(pictureBox_whitepawn7, WhitePawn7_selected, WhitePawn7_xy, d7c);
            move(pictureBox_whitepawn8, WhitePawn8_selected, WhitePawn8_xy, d7c);
            move(pictureBox_whiterook1, WhiteRook1_selected, WhiteRook1_xy, d7c);
            move(pictureBox_whiteknight1, WhiteKnight1_selected, WhiteKnight1_xy, d7c);
            move(pictureBox_whitebishop1, WhiteBishop1_selected, WhiteBishop1_xy, d7c);
            move(pictureBox_whitequeen, WhiteQueen_selected, WhiteQueen_xy, d7c);
            move(pictureBox_whiteking, WhiteKing_selected, WhiteKing_xy, d7c);
            move(pictureBox_whitebishop2, WhiteBishop2_selected, WhiteBishop2_xy, d7c);
            move(pictureBox_whiteknight2, WhiteKnight2_selected, WhiteKnight2_xy, d7c);
            move(pictureBox_whiterook2, WhiteRook2_selected, WhiteRook2_xy, d7c);
        }

        private void pictureBox_d8_Click(object sender, EventArgs e)

        {
            move(pictureBox_blackpawn1, BlackPawn1_selected, BlackPawn1_xy, d8c);
            move(pictureBox_blackpawn2, BlackPawn2_selected, BlackPawn2_xy, d8c);
            move(pictureBox_blackpawn3, BlackPawn3_selected, BlackPawn3_xy, d8c);
            move(pictureBox_blackpawn4, BlackPawn4_selected, BlackPawn4_xy, d8c);
            move(pictureBox_blackpawn5, BlackPawn5_selected, BlackPawn5_xy, d8c);
            move(pictureBox_blackpawn6, BlackPawn6_selected, BlackPawn6_xy, d8c);
            move(pictureBox_blackpawn7, BlackPawn7_selected, BlackPawn7_xy, d8c);
            move(pictureBox_blackpawn8, BlackPawn8_selected, BlackPawn8_xy, d8c);
            move(pictureBox_blackrook1, BlackRook1_selected, BlackRook1_xy, d8c);
            move(pictureBox_blackknight1, BlackKnight1_selected, BlackKnight1_xy, d8c);
            move(pictureBox_blackbishop1, BlackBishop1_selected, BlackBishop1_xy, d8c);
            move(pictureBox_blackqueen, BlackQueen_selected, BlackQueen_xy, d8c);
            move(pictureBox_blackking, BlackKing_selected, BlackKing_xy, d8c);
            move(pictureBox_blackbishop2, BlackBishop2_selected, BlackBishop2_xy, d8c);
            move(pictureBox_blackknight2, BlackKnight2_selected, BlackKnight2_xy, d8c);
            move(pictureBox_blackrook2, BlackRook2_selected, BlackRook2_xy, d8c);

            move(pictureBox_whitepawn1, WhitePawn1_selected, WhitePawn1_xy, d8c);
            move(pictureBox_whitepawn2, WhitePawn2_selected, WhitePawn2_xy, d8c);
            move(pictureBox_whitepawn3, WhitePawn3_selected, WhitePawn3_xy, d8c);
            move(pictureBox_whitepawn4, WhitePawn4_selected, WhitePawn4_xy, d8c);
            move(pictureBox_whitepawn5, WhitePawn5_selected, WhitePawn5_xy, d8c);
            move(pictureBox_whitepawn6, WhitePawn6_selected, WhitePawn6_xy, d8c);
            move(pictureBox_whitepawn7, WhitePawn7_selected, WhitePawn7_xy, d8c);
            move(pictureBox_whitepawn8, WhitePawn8_selected, WhitePawn8_xy, d8c);
            move(pictureBox_whiterook1, WhiteRook1_selected, WhiteRook1_xy, d8c);
            move(pictureBox_whiteknight1, WhiteKnight1_selected, WhiteKnight1_xy, d8c);
            move(pictureBox_whitebishop1, WhiteBishop1_selected, WhiteBishop1_xy, d8c);
            move(pictureBox_whitequeen, WhiteQueen_selected, WhiteQueen_xy, d8c);
            move(pictureBox_whiteking, WhiteKing_selected, WhiteKing_xy, d8c);
            move(pictureBox_whitebishop2, WhiteBishop2_selected, WhiteBishop2_xy, d8c);
            move(pictureBox_whiteknight2, WhiteKnight2_selected, WhiteKnight2_xy, d8c);
            move(pictureBox_whiterook2, WhiteRook2_selected, WhiteRook2_xy, d8c);
        }


        private void pictureBox_e1_Click(object sender, EventArgs e)

        {
            move(pictureBox_blackpawn1, BlackPawn1_selected, BlackPawn1_xy, e1c);
            move(pictureBox_blackpawn2, BlackPawn2_selected, BlackPawn2_xy, e1c);
            move(pictureBox_blackpawn3, BlackPawn3_selected, BlackPawn3_xy, e1c);
            move(pictureBox_blackpawn4, BlackPawn4_selected, BlackPawn4_xy, e1c);
            move(pictureBox_blackpawn5, BlackPawn5_selected, BlackPawn5_xy, e1c);
            move(pictureBox_blackpawn6, BlackPawn6_selected, BlackPawn6_xy, e1c);
            move(pictureBox_blackpawn7, BlackPawn7_selected, BlackPawn7_xy, e1c);
            move(pictureBox_blackpawn8, BlackPawn8_selected, BlackPawn8_xy, e1c);
            move(pictureBox_blackrook1, BlackRook1_selected, BlackRook1_xy, e1c);
            move(pictureBox_blackknight1, BlackKnight1_selected, BlackKnight1_xy, e1c);
            move(pictureBox_blackbishop1, BlackBishop1_selected, BlackBishop1_xy, e1c);
            move(pictureBox_blackqueen, BlackQueen_selected, BlackQueen_xy, e1c);
            move(pictureBox_blackking, BlackKing_selected, BlackKing_xy, e1c);
            move(pictureBox_blackbishop2, BlackBishop2_selected, BlackBishop2_xy, e1c);
            move(pictureBox_blackknight2, BlackKnight2_selected, BlackKnight2_xy, e1c);
            move(pictureBox_blackrook2, BlackRook2_selected, BlackRook2_xy, e1c);

            move(pictureBox_whitepawn1, WhitePawn1_selected, WhitePawn1_xy, e1c);
            move(pictureBox_whitepawn2, WhitePawn2_selected, WhitePawn2_xy, e1c);
            move(pictureBox_whitepawn3, WhitePawn3_selected, WhitePawn3_xy, e1c);
            move(pictureBox_whitepawn4, WhitePawn4_selected, WhitePawn4_xy, e1c);
            move(pictureBox_whitepawn5, WhitePawn5_selected, WhitePawn5_xy, e1c);
            move(pictureBox_whitepawn6, WhitePawn6_selected, WhitePawn6_xy, e1c);
            move(pictureBox_whitepawn7, WhitePawn7_selected, WhitePawn7_xy, e1c);
            move(pictureBox_whitepawn8, WhitePawn8_selected, WhitePawn8_xy, e1c);
            move(pictureBox_whiterook1, WhiteRook1_selected, WhiteRook1_xy, e1c);
            move(pictureBox_whiteknight1, WhiteKnight1_selected, WhiteKnight1_xy, e1c);
            move(pictureBox_whitebishop1, WhiteBishop1_selected, WhiteBishop1_xy, e1c);
            move(pictureBox_whitequeen, WhiteQueen_selected, WhiteQueen_xy, e1c);
            move(pictureBox_whiteking, WhiteKing_selected, WhiteKing_xy, e1c);
            move(pictureBox_whitebishop2, WhiteBishop2_selected, WhiteBishop2_xy, e1c);
            move(pictureBox_whiteknight2, WhiteKnight2_selected, WhiteKnight2_xy, e1c);
            move(pictureBox_whiterook2, WhiteRook2_selected, WhiteRook2_xy, e1c);
        }

        private void pictureBox_e2_Click(object sender, EventArgs e)

        {
            move(pictureBox_blackpawn1, BlackPawn1_selected, BlackPawn1_xy, e2c);
            move(pictureBox_blackpawn2, BlackPawn2_selected, BlackPawn2_xy, e2c);
            move(pictureBox_blackpawn3, BlackPawn3_selected, BlackPawn3_xy, e2c);
            move(pictureBox_blackpawn4, BlackPawn4_selected, BlackPawn4_xy, e2c);
            move(pictureBox_blackpawn5, BlackPawn5_selected, BlackPawn5_xy, e2c);
            move(pictureBox_blackpawn6, BlackPawn6_selected, BlackPawn6_xy, e2c);
            move(pictureBox_blackpawn7, BlackPawn7_selected, BlackPawn7_xy, e2c);
            move(pictureBox_blackpawn8, BlackPawn8_selected, BlackPawn8_xy, e2c);
            move(pictureBox_blackrook1, BlackRook1_selected, BlackRook1_xy, e2c);
            move(pictureBox_blackknight1, BlackKnight1_selected, BlackKnight1_xy, e2c);
            move(pictureBox_blackbishop1, BlackBishop1_selected, BlackBishop1_xy, e2c);
            move(pictureBox_blackqueen, BlackQueen_selected, BlackQueen_xy, e2c);
            move(pictureBox_blackking, BlackKing_selected, BlackKing_xy, e2c);
            move(pictureBox_blackbishop2, BlackBishop2_selected, BlackBishop2_xy, e2c);
            move(pictureBox_blackknight2, BlackKnight2_selected, BlackKnight2_xy, e2c);
            move(pictureBox_blackrook2, BlackRook2_selected, BlackRook2_xy, e2c);

            move(pictureBox_whitepawn1, WhitePawn1_selected, WhitePawn1_xy, e2c);
            move(pictureBox_whitepawn2, WhitePawn2_selected, WhitePawn2_xy, e2c);
            move(pictureBox_whitepawn3, WhitePawn3_selected, WhitePawn3_xy, e2c);
            move(pictureBox_whitepawn4, WhitePawn4_selected, WhitePawn4_xy, e2c);
            move(pictureBox_whitepawn5, WhitePawn5_selected, WhitePawn5_xy, e2c);
            move(pictureBox_whitepawn6, WhitePawn6_selected, WhitePawn6_xy, e2c);
            move(pictureBox_whitepawn7, WhitePawn7_selected, WhitePawn7_xy, e2c);
            move(pictureBox_whitepawn8, WhitePawn8_selected, WhitePawn8_xy, e2c);
            move(pictureBox_whiterook1, WhiteRook1_selected, WhiteRook1_xy, e2c);
            move(pictureBox_whiteknight1, WhiteKnight1_selected, WhiteKnight1_xy, e2c);
            move(pictureBox_whitebishop1, WhiteBishop1_selected, WhiteBishop1_xy, e2c);
            move(pictureBox_whitequeen, WhiteQueen_selected, WhiteQueen_xy, e2c);
            move(pictureBox_whiteking, WhiteKing_selected, WhiteKing_xy, e2c);
            move(pictureBox_whitebishop2, WhiteBishop2_selected, WhiteBishop2_xy, e2c);
            move(pictureBox_whiteknight2, WhiteKnight2_selected, WhiteKnight2_xy, e2c);
            move(pictureBox_whiterook2, WhiteRook2_selected, WhiteRook2_xy, e2c);
        }

        private void pictureBox_e3_Click(object sender, EventArgs e)

        {
            move(pictureBox_blackpawn1, BlackPawn1_selected, BlackPawn1_xy, e3c);
            move(pictureBox_blackpawn2, BlackPawn2_selected, BlackPawn2_xy, e3c);
            move(pictureBox_blackpawn3, BlackPawn3_selected, BlackPawn3_xy, e3c);
            move(pictureBox_blackpawn4, BlackPawn4_selected, BlackPawn4_xy, e3c);
            move(pictureBox_blackpawn5, BlackPawn5_selected, BlackPawn5_xy, e3c);
            move(pictureBox_blackpawn6, BlackPawn6_selected, BlackPawn6_xy, e3c);
            move(pictureBox_blackpawn7, BlackPawn7_selected, BlackPawn7_xy, e3c);
            move(pictureBox_blackpawn8, BlackPawn8_selected, BlackPawn8_xy, e3c);
            move(pictureBox_blackrook1, BlackRook1_selected, BlackRook1_xy, e3c);
            move(pictureBox_blackknight1, BlackKnight1_selected, BlackKnight1_xy, e3c);
            move(pictureBox_blackbishop1, BlackBishop1_selected, BlackBishop1_xy, e3c);
            move(pictureBox_blackqueen, BlackQueen_selected, BlackQueen_xy, e3c);
            move(pictureBox_blackking, BlackKing_selected, BlackKing_xy, e3c);
            move(pictureBox_blackbishop2, BlackBishop2_selected, BlackBishop2_xy, e3c);
            move(pictureBox_blackknight2, BlackKnight2_selected, BlackKnight2_xy, e3c);
            move(pictureBox_blackrook2, BlackRook2_selected, BlackRook2_xy, e3c);

            move(pictureBox_whitepawn1, WhitePawn1_selected, WhitePawn1_xy, e3c);
            move(pictureBox_whitepawn2, WhitePawn2_selected, WhitePawn2_xy, e3c);
            move(pictureBox_whitepawn3, WhitePawn3_selected, WhitePawn3_xy, e3c);
            move(pictureBox_whitepawn4, WhitePawn4_selected, WhitePawn4_xy, e3c);
            move(pictureBox_whitepawn5, WhitePawn5_selected, WhitePawn5_xy, e3c);
            move(pictureBox_whitepawn6, WhitePawn6_selected, WhitePawn6_xy, e3c);
            move(pictureBox_whitepawn7, WhitePawn7_selected, WhitePawn7_xy, e3c);
            move(pictureBox_whitepawn8, WhitePawn8_selected, WhitePawn8_xy, e3c);
            move(pictureBox_whiterook1, WhiteRook1_selected, WhiteRook1_xy, e3c);
            move(pictureBox_whiteknight1, WhiteKnight1_selected, WhiteKnight1_xy, e3c);
            move(pictureBox_whitebishop1, WhiteBishop1_selected, WhiteBishop1_xy, e3c);
            move(pictureBox_whitequeen, WhiteQueen_selected, WhiteQueen_xy, e3c);
            move(pictureBox_whiteking, WhiteKing_selected, WhiteKing_xy, e3c);
            move(pictureBox_whitebishop2, WhiteBishop2_selected, WhiteBishop2_xy, e3c);
            move(pictureBox_whiteknight2, WhiteKnight2_selected, WhiteKnight2_xy, e3c);
            move(pictureBox_whiterook2, WhiteRook2_selected, WhiteRook2_xy, e3c);
        }

        private void pictureBox_e4_Click(object sender, EventArgs e)

        {
            move(pictureBox_blackpawn1, BlackPawn1_selected, BlackPawn1_xy, e4c);
            move(pictureBox_blackpawn2, BlackPawn2_selected, BlackPawn2_xy, e4c);
            move(pictureBox_blackpawn3, BlackPawn3_selected, BlackPawn3_xy, e4c);
            move(pictureBox_blackpawn4, BlackPawn4_selected, BlackPawn4_xy, e4c);
            move(pictureBox_blackpawn5, BlackPawn5_selected, BlackPawn5_xy, e4c);
            move(pictureBox_blackpawn6, BlackPawn6_selected, BlackPawn6_xy, e4c);
            move(pictureBox_blackpawn7, BlackPawn7_selected, BlackPawn7_xy, e4c);
            move(pictureBox_blackpawn8, BlackPawn8_selected, BlackPawn8_xy, e4c);
            move(pictureBox_blackrook1, BlackRook1_selected, BlackRook1_xy, e4c);
            move(pictureBox_blackknight1, BlackKnight1_selected, BlackKnight1_xy, e4c);
            move(pictureBox_blackbishop1, BlackBishop1_selected, BlackBishop1_xy, e4c);
            move(pictureBox_blackqueen, BlackQueen_selected, BlackQueen_xy, e4c);
            move(pictureBox_blackking, BlackKing_selected, BlackKing_xy, e4c);
            move(pictureBox_blackbishop2, BlackBishop2_selected, BlackBishop2_xy, e4c);
            move(pictureBox_blackknight2, BlackKnight2_selected, BlackKnight2_xy, e4c);
            move(pictureBox_blackrook2, BlackRook2_selected, BlackRook2_xy, e4c);

            move(pictureBox_whitepawn1, WhitePawn1_selected, WhitePawn1_xy, e4c);
            move(pictureBox_whitepawn2, WhitePawn2_selected, WhitePawn2_xy, e4c);
            move(pictureBox_whitepawn3, WhitePawn3_selected, WhitePawn3_xy, e4c);
            move(pictureBox_whitepawn4, WhitePawn4_selected, WhitePawn4_xy, e4c);
            move(pictureBox_whitepawn5, WhitePawn5_selected, WhitePawn5_xy, e4c);
            move(pictureBox_whitepawn6, WhitePawn6_selected, WhitePawn6_xy, e4c);
            move(pictureBox_whitepawn7, WhitePawn7_selected, WhitePawn7_xy, e4c);
            move(pictureBox_whitepawn8, WhitePawn8_selected, WhitePawn8_xy, e4c);
            move(pictureBox_whiterook1, WhiteRook1_selected, WhiteRook1_xy, e4c);
            move(pictureBox_whiteknight1, WhiteKnight1_selected, WhiteKnight1_xy, e4c);
            move(pictureBox_whitebishop1, WhiteBishop1_selected, WhiteBishop1_xy, e4c);
            move(pictureBox_whitequeen, WhiteQueen_selected, WhiteQueen_xy, e4c);
            move(pictureBox_whiteking, WhiteKing_selected, WhiteKing_xy, e4c);
            move(pictureBox_whitebishop2, WhiteBishop2_selected, WhiteBishop2_xy, e4c);
            move(pictureBox_whiteknight2, WhiteKnight2_selected, WhiteKnight2_xy, e4c);
            move(pictureBox_whiterook2, WhiteRook2_selected, WhiteRook2_xy, e4c);
        }

        private void pictureBox_e5_Click(object sender, EventArgs e)

        {
            move(pictureBox_blackpawn1, BlackPawn1_selected, BlackPawn1_xy, e5c);
            move(pictureBox_blackpawn2, BlackPawn2_selected, BlackPawn2_xy, e5c);
            move(pictureBox_blackpawn3, BlackPawn3_selected, BlackPawn3_xy, e5c);
            move(pictureBox_blackpawn4, BlackPawn4_selected, BlackPawn4_xy, e5c);
            move(pictureBox_blackpawn5, BlackPawn5_selected, BlackPawn5_xy, e5c);
            move(pictureBox_blackpawn6, BlackPawn6_selected, BlackPawn6_xy, e5c);
            move(pictureBox_blackpawn7, BlackPawn7_selected, BlackPawn7_xy, e5c);
            move(pictureBox_blackpawn8, BlackPawn8_selected, BlackPawn8_xy, e5c);
            move(pictureBox_blackrook1, BlackRook1_selected, BlackRook1_xy, e5c);
            move(pictureBox_blackknight1, BlackKnight1_selected, BlackKnight1_xy, e5c);
            move(pictureBox_blackbishop1, BlackBishop1_selected, BlackBishop1_xy, e5c);
            move(pictureBox_blackqueen, BlackQueen_selected, BlackQueen_xy, e5c);
            move(pictureBox_blackking, BlackKing_selected, BlackKing_xy, e5c);
            move(pictureBox_blackbishop2, BlackBishop2_selected, BlackBishop2_xy, e5c);
            move(pictureBox_blackknight2, BlackKnight2_selected, BlackKnight2_xy, e5c);
            move(pictureBox_blackrook2, BlackRook2_selected, BlackRook2_xy, e5c);

            move(pictureBox_whitepawn1, WhitePawn1_selected, WhitePawn1_xy, e5c);
            move(pictureBox_whitepawn2, WhitePawn2_selected, WhitePawn2_xy, e5c);
            move(pictureBox_whitepawn3, WhitePawn3_selected, WhitePawn3_xy, e5c);
            move(pictureBox_whitepawn4, WhitePawn4_selected, WhitePawn4_xy, e5c);
            move(pictureBox_whitepawn5, WhitePawn5_selected, WhitePawn5_xy, e5c);
            move(pictureBox_whitepawn6, WhitePawn6_selected, WhitePawn6_xy, e5c);
            move(pictureBox_whitepawn7, WhitePawn7_selected, WhitePawn7_xy, e5c);
            move(pictureBox_whitepawn8, WhitePawn8_selected, WhitePawn8_xy, e5c);
            move(pictureBox_whiterook1, WhiteRook1_selected, WhiteRook1_xy, e5c);
            move(pictureBox_whiteknight1, WhiteKnight1_selected, WhiteKnight1_xy, e5c);
            move(pictureBox_whitebishop1, WhiteBishop1_selected, WhiteBishop1_xy, e5c);
            move(pictureBox_whitequeen, WhiteQueen_selected, WhiteQueen_xy, e5c);
            move(pictureBox_whiteking, WhiteKing_selected, WhiteKing_xy, e5c);
            move(pictureBox_whitebishop2, WhiteBishop2_selected, WhiteBishop2_xy, e5c);
            move(pictureBox_whiteknight2, WhiteKnight2_selected, WhiteKnight2_xy, e5c);
            move(pictureBox_whiterook2, WhiteRook2_selected, WhiteRook2_xy, e5c);
        }

        private void pictureBox_e6_Click(object sender, EventArgs e)

        {
            move(pictureBox_blackpawn1, BlackPawn1_selected, BlackPawn1_xy, e6c);
            move(pictureBox_blackpawn2, BlackPawn2_selected, BlackPawn2_xy, e6c);
            move(pictureBox_blackpawn3, BlackPawn3_selected, BlackPawn3_xy, e6c);
            move(pictureBox_blackpawn4, BlackPawn4_selected, BlackPawn4_xy, e6c);
            move(pictureBox_blackpawn5, BlackPawn5_selected, BlackPawn5_xy, e6c);
            move(pictureBox_blackpawn6, BlackPawn6_selected, BlackPawn6_xy, e6c);
            move(pictureBox_blackpawn7, BlackPawn7_selected, BlackPawn7_xy, e6c);
            move(pictureBox_blackpawn8, BlackPawn8_selected, BlackPawn8_xy, e6c);
            move(pictureBox_blackrook1, BlackRook1_selected, BlackRook1_xy, e6c);
            move(pictureBox_blackknight1, BlackKnight1_selected, BlackKnight1_xy, e6c);
            move(pictureBox_blackbishop1, BlackBishop1_selected, BlackBishop1_xy, e6c);
            move(pictureBox_blackqueen, BlackQueen_selected, BlackQueen_xy, e6c);
            move(pictureBox_blackking, BlackKing_selected, BlackKing_xy, e6c);
            move(pictureBox_blackbishop2, BlackBishop2_selected, BlackBishop2_xy, e6c);
            move(pictureBox_blackknight2, BlackKnight2_selected, BlackKnight2_xy, e6c);
            move(pictureBox_blackrook2, BlackRook2_selected, BlackRook2_xy, e6c);

            move(pictureBox_whitepawn1, WhitePawn1_selected, WhitePawn1_xy, e6c);
            move(pictureBox_whitepawn2, WhitePawn2_selected, WhitePawn2_xy, e6c);
            move(pictureBox_whitepawn3, WhitePawn3_selected, WhitePawn3_xy, e6c);
            move(pictureBox_whitepawn4, WhitePawn4_selected, WhitePawn4_xy, e6c);
            move(pictureBox_whitepawn5, WhitePawn5_selected, WhitePawn5_xy, e6c);
            move(pictureBox_whitepawn6, WhitePawn6_selected, WhitePawn6_xy, e6c);
            move(pictureBox_whitepawn7, WhitePawn7_selected, WhitePawn7_xy, e6c);
            move(pictureBox_whitepawn8, WhitePawn8_selected, WhitePawn8_xy, e6c);
            move(pictureBox_whiterook1, WhiteRook1_selected, WhiteRook1_xy, e6c);
            move(pictureBox_whiteknight1, WhiteKnight1_selected, WhiteKnight1_xy, e6c);
            move(pictureBox_whitebishop1, WhiteBishop1_selected, WhiteBishop1_xy, e6c);
            move(pictureBox_whitequeen, WhiteQueen_selected, WhiteQueen_xy, e6c);
            move(pictureBox_whiteking, WhiteKing_selected, WhiteKing_xy, e6c);
            move(pictureBox_whitebishop2, WhiteBishop2_selected, WhiteBishop2_xy, e6c);
            move(pictureBox_whiteknight2, WhiteKnight2_selected, WhiteKnight2_xy, e6c);
            move(pictureBox_whiterook2, WhiteRook2_selected, WhiteRook2_xy, e6c);
        }

        private void pictureBox_e7_Click(object sender, EventArgs e)

        {
            move(pictureBox_blackpawn1, BlackPawn1_selected, BlackPawn1_xy, e7c);
            move(pictureBox_blackpawn2, BlackPawn2_selected, BlackPawn2_xy, e7c);
            move(pictureBox_blackpawn3, BlackPawn3_selected, BlackPawn3_xy, e7c);
            move(pictureBox_blackpawn4, BlackPawn4_selected, BlackPawn4_xy, e7c);
            move(pictureBox_blackpawn5, BlackPawn5_selected, BlackPawn5_xy, e7c);
            move(pictureBox_blackpawn6, BlackPawn6_selected, BlackPawn6_xy, e7c);
            move(pictureBox_blackpawn7, BlackPawn7_selected, BlackPawn7_xy, e7c);
            move(pictureBox_blackpawn8, BlackPawn8_selected, BlackPawn8_xy, e7c);
            move(pictureBox_blackrook1, BlackRook1_selected, BlackRook1_xy, e7c);
            move(pictureBox_blackknight1, BlackKnight1_selected, BlackKnight1_xy, e7c);
            move(pictureBox_blackbishop1, BlackBishop1_selected, BlackBishop1_xy, e7c);
            move(pictureBox_blackqueen, BlackQueen_selected, BlackQueen_xy, e7c);
            move(pictureBox_blackking, BlackKing_selected, BlackKing_xy, e7c);
            move(pictureBox_blackbishop2, BlackBishop2_selected, BlackBishop2_xy, e7c);
            move(pictureBox_blackknight2, BlackKnight2_selected, BlackKnight2_xy, e7c);
            move(pictureBox_blackrook2, BlackRook2_selected, BlackRook2_xy, e7c);

            move(pictureBox_whitepawn1, WhitePawn1_selected, WhitePawn1_xy, e7c);
            move(pictureBox_whitepawn2, WhitePawn2_selected, WhitePawn2_xy, e7c);
            move(pictureBox_whitepawn3, WhitePawn3_selected, WhitePawn3_xy, e7c);
            move(pictureBox_whitepawn4, WhitePawn4_selected, WhitePawn4_xy, e7c);
            move(pictureBox_whitepawn5, WhitePawn5_selected, WhitePawn5_xy, e7c);
            move(pictureBox_whitepawn6, WhitePawn6_selected, WhitePawn6_xy, e7c);
            move(pictureBox_whitepawn7, WhitePawn7_selected, WhitePawn7_xy, e7c);
            move(pictureBox_whitepawn8, WhitePawn8_selected, WhitePawn8_xy, e7c);
            move(pictureBox_whiterook1, WhiteRook1_selected, WhiteRook1_xy, e7c);
            move(pictureBox_whiteknight1, WhiteKnight1_selected, WhiteKnight1_xy, e7c);
            move(pictureBox_whitebishop1, WhiteBishop1_selected, WhiteBishop1_xy, e7c);
            move(pictureBox_whitequeen, WhiteQueen_selected, WhiteQueen_xy, e7c);
            move(pictureBox_whiteking, WhiteKing_selected, WhiteKing_xy, e7c);
            move(pictureBox_whitebishop2, WhiteBishop2_selected, WhiteBishop2_xy, e7c);
            move(pictureBox_whiteknight2, WhiteKnight2_selected, WhiteKnight2_xy, e7c);
            move(pictureBox_whiterook2, WhiteRook2_selected, WhiteRook2_xy, e7c);
        }

        private void pictureBox_e8_Click(object sender, EventArgs e)

        {
            move(pictureBox_blackpawn1, BlackPawn1_selected, BlackPawn1_xy, e8c);
            move(pictureBox_blackpawn2, BlackPawn2_selected, BlackPawn2_xy, e8c);
            move(pictureBox_blackpawn3, BlackPawn3_selected, BlackPawn3_xy, e8c);
            move(pictureBox_blackpawn4, BlackPawn4_selected, BlackPawn4_xy, e8c);
            move(pictureBox_blackpawn5, BlackPawn5_selected, BlackPawn5_xy, e8c);
            move(pictureBox_blackpawn6, BlackPawn6_selected, BlackPawn6_xy, e8c);
            move(pictureBox_blackpawn7, BlackPawn7_selected, BlackPawn7_xy, e8c);
            move(pictureBox_blackpawn8, BlackPawn8_selected, BlackPawn8_xy, e8c);
            move(pictureBox_blackrook1, BlackRook1_selected, BlackRook1_xy, e8c);
            move(pictureBox_blackknight1, BlackKnight1_selected, BlackKnight1_xy, e8c);
            move(pictureBox_blackbishop1, BlackBishop1_selected, BlackBishop1_xy, e8c);
            move(pictureBox_blackqueen, BlackQueen_selected, BlackQueen_xy, e8c);
            move(pictureBox_blackking, BlackKing_selected, BlackKing_xy, e8c);
            move(pictureBox_blackbishop2, BlackBishop2_selected, BlackBishop2_xy, e8c);
            move(pictureBox_blackknight2, BlackKnight2_selected, BlackKnight2_xy, e8c);
            move(pictureBox_blackrook2, BlackRook2_selected, BlackRook2_xy, e8c);

            move(pictureBox_whitepawn1, WhitePawn1_selected, WhitePawn1_xy, e8c);
            move(pictureBox_whitepawn2, WhitePawn2_selected, WhitePawn2_xy, e8c);
            move(pictureBox_whitepawn3, WhitePawn3_selected, WhitePawn3_xy, e8c);
            move(pictureBox_whitepawn4, WhitePawn4_selected, WhitePawn4_xy, e8c);
            move(pictureBox_whitepawn5, WhitePawn5_selected, WhitePawn5_xy, e8c);
            move(pictureBox_whitepawn6, WhitePawn6_selected, WhitePawn6_xy, e8c);
            move(pictureBox_whitepawn7, WhitePawn7_selected, WhitePawn7_xy, e8c);
            move(pictureBox_whitepawn8, WhitePawn8_selected, WhitePawn8_xy, e8c);
            move(pictureBox_whiterook1, WhiteRook1_selected, WhiteRook1_xy, e8c);
            move(pictureBox_whiteknight1, WhiteKnight1_selected, WhiteKnight1_xy, e8c);
            move(pictureBox_whitebishop1, WhiteBishop1_selected, WhiteBishop1_xy, e8c);
            move(pictureBox_whitequeen, WhiteQueen_selected, WhiteQueen_xy, e8c);
            move(pictureBox_whiteking, WhiteKing_selected, WhiteKing_xy, e8c);
            move(pictureBox_whitebishop2, WhiteBishop2_selected, WhiteBishop2_xy, e8c);
            move(pictureBox_whiteknight2, WhiteKnight2_selected, WhiteKnight2_xy, e8c);
            move(pictureBox_whiterook2, WhiteRook2_selected, WhiteRook2_xy, e8c);
        }


        private void pictureBox_f1_Click(object sender, EventArgs e)

        {
            move(pictureBox_blackpawn1, BlackPawn1_selected, BlackPawn1_xy, f1c);
            move(pictureBox_blackpawn2, BlackPawn2_selected, BlackPawn2_xy, f1c);
            move(pictureBox_blackpawn3, BlackPawn3_selected, BlackPawn3_xy, f1c);
            move(pictureBox_blackpawn4, BlackPawn4_selected, BlackPawn4_xy, f1c);
            move(pictureBox_blackpawn5, BlackPawn5_selected, BlackPawn5_xy, f1c);
            move(pictureBox_blackpawn6, BlackPawn6_selected, BlackPawn6_xy, f1c);
            move(pictureBox_blackpawn7, BlackPawn7_selected, BlackPawn7_xy, f1c);
            move(pictureBox_blackpawn8, BlackPawn8_selected, BlackPawn8_xy, f1c);
            move(pictureBox_blackrook1, BlackRook1_selected, BlackRook1_xy, f1c);
            move(pictureBox_blackknight1, BlackKnight1_selected, BlackKnight1_xy, f1c);
            move(pictureBox_blackbishop1, BlackBishop1_selected, BlackBishop1_xy, f1c);
            move(pictureBox_blackqueen, BlackQueen_selected, BlackQueen_xy, f1c);
            move(pictureBox_blackking, BlackKing_selected, BlackKing_xy, f1c);
            move(pictureBox_blackbishop2, BlackBishop2_selected, BlackBishop2_xy, f1c);
            move(pictureBox_blackknight2, BlackKnight2_selected, BlackKnight2_xy, f1c);
            move(pictureBox_blackrook2, BlackRook2_selected, BlackRook2_xy, f1c);

            move(pictureBox_whitepawn1, WhitePawn1_selected, WhitePawn1_xy, f1c);
            move(pictureBox_whitepawn2, WhitePawn2_selected, WhitePawn2_xy, f1c);
            move(pictureBox_whitepawn3, WhitePawn3_selected, WhitePawn3_xy, f1c);
            move(pictureBox_whitepawn4, WhitePawn4_selected, WhitePawn4_xy, f1c);
            move(pictureBox_whitepawn5, WhitePawn5_selected, WhitePawn5_xy, f1c);
            move(pictureBox_whitepawn6, WhitePawn6_selected, WhitePawn6_xy, f1c);
            move(pictureBox_whitepawn7, WhitePawn7_selected, WhitePawn7_xy, f1c);
            move(pictureBox_whitepawn8, WhitePawn8_selected, WhitePawn8_xy, f1c);
            move(pictureBox_whiterook1, WhiteRook1_selected, WhiteRook1_xy, f1c);
            move(pictureBox_whiteknight1, WhiteKnight1_selected, WhiteKnight1_xy, f1c);
            move(pictureBox_whitebishop1, WhiteBishop1_selected, WhiteBishop1_xy, f1c);
            move(pictureBox_whitequeen, WhiteQueen_selected, WhiteQueen_xy, f1c);
            move(pictureBox_whiteking, WhiteKing_selected, WhiteKing_xy, f1c);
            move(pictureBox_whitebishop2, WhiteBishop2_selected, WhiteBishop2_xy, f1c);
            move(pictureBox_whiteknight2, WhiteKnight2_selected, WhiteKnight2_xy, f1c);
            move(pictureBox_whiterook2, WhiteRook2_selected, WhiteRook2_xy, f1c);
        }

        private void pictureBox_f2_Click(object sender, EventArgs e)

        {
            move(pictureBox_blackpawn1, BlackPawn1_selected, BlackPawn1_xy, f2c);
            move(pictureBox_blackpawn2, BlackPawn2_selected, BlackPawn2_xy, f2c);
            move(pictureBox_blackpawn3, BlackPawn3_selected, BlackPawn3_xy, f2c);
            move(pictureBox_blackpawn4, BlackPawn4_selected, BlackPawn4_xy, f2c);
            move(pictureBox_blackpawn5, BlackPawn5_selected, BlackPawn5_xy, f2c);
            move(pictureBox_blackpawn6, BlackPawn6_selected, BlackPawn6_xy, f2c);
            move(pictureBox_blackpawn7, BlackPawn7_selected, BlackPawn7_xy, f2c);
            move(pictureBox_blackpawn8, BlackPawn8_selected, BlackPawn8_xy, f2c);
            move(pictureBox_blackrook1, BlackRook1_selected, BlackRook1_xy, f2c);
            move(pictureBox_blackknight1, BlackKnight1_selected, BlackKnight1_xy, f2c);
            move(pictureBox_blackbishop1, BlackBishop1_selected, BlackBishop1_xy, f2c);
            move(pictureBox_blackqueen, BlackQueen_selected, BlackQueen_xy, f2c);
            move(pictureBox_blackking, BlackKing_selected, BlackKing_xy, f2c);
            move(pictureBox_blackbishop2, BlackBishop2_selected, BlackBishop2_xy, f2c);
            move(pictureBox_blackknight2, BlackKnight2_selected, BlackKnight2_xy, f2c);
            move(pictureBox_blackrook2, BlackRook2_selected, BlackRook2_xy, f2c);

            move(pictureBox_whitepawn1, WhitePawn1_selected, WhitePawn1_xy, f2c);
            move(pictureBox_whitepawn2, WhitePawn2_selected, WhitePawn2_xy, f2c);
            move(pictureBox_whitepawn3, WhitePawn3_selected, WhitePawn3_xy, f2c);
            move(pictureBox_whitepawn4, WhitePawn4_selected, WhitePawn4_xy, f2c);
            move(pictureBox_whitepawn5, WhitePawn5_selected, WhitePawn5_xy, f2c);
            move(pictureBox_whitepawn6, WhitePawn6_selected, WhitePawn6_xy, f2c);
            move(pictureBox_whitepawn7, WhitePawn7_selected, WhitePawn7_xy, f2c);
            move(pictureBox_whitepawn8, WhitePawn8_selected, WhitePawn8_xy, f2c);
            move(pictureBox_whiterook1, WhiteRook1_selected, WhiteRook1_xy, f2c);
            move(pictureBox_whiteknight1, WhiteKnight1_selected, WhiteKnight1_xy, f2c);
            move(pictureBox_whitebishop1, WhiteBishop1_selected, WhiteBishop1_xy, f2c);
            move(pictureBox_whitequeen, WhiteQueen_selected, WhiteQueen_xy, f2c);
            move(pictureBox_whiteking, WhiteKing_selected, WhiteKing_xy, f2c);
            move(pictureBox_whitebishop2, WhiteBishop2_selected, WhiteBishop2_xy, f2c);
            move(pictureBox_whiteknight2, WhiteKnight2_selected, WhiteKnight2_xy, f2c);
            move(pictureBox_whiterook2, WhiteRook2_selected, WhiteRook2_xy, f2c);
        }

        private void pictureBox_f3_Click(object sender, EventArgs e)

        {
            move(pictureBox_blackpawn1, BlackPawn1_selected, BlackPawn1_xy, f3c);
            move(pictureBox_blackpawn2, BlackPawn2_selected, BlackPawn2_xy, f3c);
            move(pictureBox_blackpawn3, BlackPawn3_selected, BlackPawn3_xy, f3c);
            move(pictureBox_blackpawn4, BlackPawn4_selected, BlackPawn4_xy, f3c);
            move(pictureBox_blackpawn5, BlackPawn5_selected, BlackPawn5_xy, f3c);
            move(pictureBox_blackpawn6, BlackPawn6_selected, BlackPawn6_xy, f3c);
            move(pictureBox_blackpawn7, BlackPawn7_selected, BlackPawn7_xy, f3c);
            move(pictureBox_blackpawn8, BlackPawn8_selected, BlackPawn8_xy, f3c);
            move(pictureBox_blackrook1, BlackRook1_selected, BlackRook1_xy, f3c);
            move(pictureBox_blackknight1, BlackKnight1_selected, BlackKnight1_xy, f3c);
            move(pictureBox_blackbishop1, BlackBishop1_selected, BlackBishop1_xy, f3c);
            move(pictureBox_blackqueen, BlackQueen_selected, BlackQueen_xy, f3c);
            move(pictureBox_blackking, BlackKing_selected, BlackKing_xy, f3c);
            move(pictureBox_blackbishop2, BlackBishop2_selected, BlackBishop2_xy, f3c);
            move(pictureBox_blackknight2, BlackKnight2_selected, BlackKnight2_xy, f3c);
            move(pictureBox_blackrook2, BlackRook2_selected, BlackRook2_xy, f3c);

            move(pictureBox_whitepawn1, WhitePawn1_selected, WhitePawn1_xy, f3c);
            move(pictureBox_whitepawn2, WhitePawn2_selected, WhitePawn2_xy, f3c);
            move(pictureBox_whitepawn3, WhitePawn3_selected, WhitePawn3_xy, f3c);
            move(pictureBox_whitepawn4, WhitePawn4_selected, WhitePawn4_xy, f3c);
            move(pictureBox_whitepawn5, WhitePawn5_selected, WhitePawn5_xy, f3c);
            move(pictureBox_whitepawn6, WhitePawn6_selected, WhitePawn6_xy, f3c);
            move(pictureBox_whitepawn7, WhitePawn7_selected, WhitePawn7_xy, f3c);
            move(pictureBox_whitepawn8, WhitePawn8_selected, WhitePawn8_xy, f3c);
            move(pictureBox_whiterook1, WhiteRook1_selected, WhiteRook1_xy, f3c);
            move(pictureBox_whiteknight1, WhiteKnight1_selected, WhiteKnight1_xy, f3c);
            move(pictureBox_whitebishop1, WhiteBishop1_selected, WhiteBishop1_xy, f3c);
            move(pictureBox_whitequeen, WhiteQueen_selected, WhiteQueen_xy, f3c);
            move(pictureBox_whiteking, WhiteKing_selected, WhiteKing_xy, f3c);
            move(pictureBox_whitebishop2, WhiteBishop2_selected, WhiteBishop2_xy, f3c);
            move(pictureBox_whiteknight2, WhiteKnight2_selected, WhiteKnight2_xy, f3c);
            move(pictureBox_whiterook2, WhiteRook2_selected, WhiteRook2_xy, f3c);
        }

        private void pictureBox_f4_Click(object sender, EventArgs e)

        {
            move(pictureBox_blackpawn1, BlackPawn1_selected, BlackPawn1_xy, f4c);
            move(pictureBox_blackpawn2, BlackPawn2_selected, BlackPawn2_xy, f4c);
            move(pictureBox_blackpawn3, BlackPawn3_selected, BlackPawn3_xy, f4c);
            move(pictureBox_blackpawn4, BlackPawn4_selected, BlackPawn4_xy, f4c);
            move(pictureBox_blackpawn5, BlackPawn5_selected, BlackPawn5_xy, f4c);
            move(pictureBox_blackpawn6, BlackPawn6_selected, BlackPawn6_xy, f4c);
            move(pictureBox_blackpawn7, BlackPawn7_selected, BlackPawn7_xy, f4c);
            move(pictureBox_blackpawn8, BlackPawn8_selected, BlackPawn8_xy, f4c);
            move(pictureBox_blackrook1, BlackRook1_selected, BlackRook1_xy, f4c);
            move(pictureBox_blackknight1, BlackKnight1_selected, BlackKnight1_xy, f4c);
            move(pictureBox_blackbishop1, BlackBishop1_selected, BlackBishop1_xy, f4c);
            move(pictureBox_blackqueen, BlackQueen_selected, BlackQueen_xy, f4c);
            move(pictureBox_blackking, BlackKing_selected, BlackKing_xy, f4c);
            move(pictureBox_blackbishop2, BlackBishop2_selected, BlackBishop2_xy, f4c);
            move(pictureBox_blackknight2, BlackKnight2_selected, BlackKnight2_xy, f4c);
            move(pictureBox_blackrook2, BlackRook2_selected, BlackRook2_xy, f4c);

            move(pictureBox_whitepawn1, WhitePawn1_selected, WhitePawn1_xy, f4c);
            move(pictureBox_whitepawn2, WhitePawn2_selected, WhitePawn2_xy, f4c);
            move(pictureBox_whitepawn3, WhitePawn3_selected, WhitePawn3_xy, f4c);
            move(pictureBox_whitepawn4, WhitePawn4_selected, WhitePawn4_xy, f4c);
            move(pictureBox_whitepawn5, WhitePawn5_selected, WhitePawn5_xy, f4c);
            move(pictureBox_whitepawn6, WhitePawn6_selected, WhitePawn6_xy, f4c);
            move(pictureBox_whitepawn7, WhitePawn7_selected, WhitePawn7_xy, f4c);
            move(pictureBox_whitepawn8, WhitePawn8_selected, WhitePawn8_xy, f4c);
            move(pictureBox_whiterook1, WhiteRook1_selected, WhiteRook1_xy, f4c);
            move(pictureBox_whiteknight1, WhiteKnight1_selected, WhiteKnight1_xy, f4c);
            move(pictureBox_whitebishop1, WhiteBishop1_selected, WhiteBishop1_xy, f4c);
            move(pictureBox_whitequeen, WhiteQueen_selected, WhiteQueen_xy, f4c);
            move(pictureBox_whiteking, WhiteKing_selected, WhiteKing_xy, f4c);
            move(pictureBox_whitebishop2, WhiteBishop2_selected, WhiteBishop2_xy, f4c);
            move(pictureBox_whiteknight2, WhiteKnight2_selected, WhiteKnight2_xy, f4c);
            move(pictureBox_whiterook2, WhiteRook2_selected, WhiteRook2_xy, f4c);
        }

        private void pictureBox_f5_Click(object sender, EventArgs e)

        {
            move(pictureBox_blackpawn1, BlackPawn1_selected, BlackPawn1_xy, f5c);
            move(pictureBox_blackpawn2, BlackPawn2_selected, BlackPawn2_xy, f5c);
            move(pictureBox_blackpawn3, BlackPawn3_selected, BlackPawn3_xy, f5c);
            move(pictureBox_blackpawn4, BlackPawn4_selected, BlackPawn4_xy, f5c);
            move(pictureBox_blackpawn5, BlackPawn5_selected, BlackPawn5_xy, f5c);
            move(pictureBox_blackpawn6, BlackPawn6_selected, BlackPawn6_xy, f5c);
            move(pictureBox_blackpawn7, BlackPawn7_selected, BlackPawn7_xy, f5c);
            move(pictureBox_blackpawn8, BlackPawn8_selected, BlackPawn8_xy, f5c);
            move(pictureBox_blackrook1, BlackRook1_selected, BlackRook1_xy, f5c);
            move(pictureBox_blackknight1, BlackKnight1_selected, BlackKnight1_xy, f5c);
            move(pictureBox_blackbishop1, BlackBishop1_selected, BlackBishop1_xy, f5c);
            move(pictureBox_blackqueen, BlackQueen_selected, BlackQueen_xy, f5c);
            move(pictureBox_blackking, BlackKing_selected, BlackKing_xy, f5c);
            move(pictureBox_blackbishop2, BlackBishop2_selected, BlackBishop2_xy, f5c);
            move(pictureBox_blackknight2, BlackKnight2_selected, BlackKnight2_xy, f5c);
            move(pictureBox_blackrook2, BlackRook2_selected, BlackRook2_xy, f5c);

            move(pictureBox_whitepawn1, WhitePawn1_selected, WhitePawn1_xy, f5c);
            move(pictureBox_whitepawn2, WhitePawn2_selected, WhitePawn2_xy, f5c);
            move(pictureBox_whitepawn3, WhitePawn3_selected, WhitePawn3_xy, f5c);
            move(pictureBox_whitepawn4, WhitePawn4_selected, WhitePawn4_xy, f5c);
            move(pictureBox_whitepawn5, WhitePawn5_selected, WhitePawn5_xy, f5c);
            move(pictureBox_whitepawn6, WhitePawn6_selected, WhitePawn6_xy, f5c);
            move(pictureBox_whitepawn7, WhitePawn7_selected, WhitePawn7_xy, f5c);
            move(pictureBox_whitepawn8, WhitePawn8_selected, WhitePawn8_xy, f5c);
            move(pictureBox_whiterook1, WhiteRook1_selected, WhiteRook1_xy, f5c);
            move(pictureBox_whiteknight1, WhiteKnight1_selected, WhiteKnight1_xy, f5c);
            move(pictureBox_whitebishop1, WhiteBishop1_selected, WhiteBishop1_xy, f5c);
            move(pictureBox_whitequeen, WhiteQueen_selected, WhiteQueen_xy, f5c);
            move(pictureBox_whiteking, WhiteKing_selected, WhiteKing_xy, f5c);
            move(pictureBox_whitebishop2, WhiteBishop2_selected, WhiteBishop2_xy, f5c);
            move(pictureBox_whiteknight2, WhiteKnight2_selected, WhiteKnight2_xy, f5c);
            move(pictureBox_whiterook2, WhiteRook2_selected, WhiteRook2_xy, f5c);
        }

        private void pictureBox_f6_Click(object sender, EventArgs e)

        {
            move(pictureBox_blackpawn1, BlackPawn1_selected, BlackPawn1_xy, f6c);
            move(pictureBox_blackpawn2, BlackPawn2_selected, BlackPawn2_xy, f6c);
            move(pictureBox_blackpawn3, BlackPawn3_selected, BlackPawn3_xy, f6c);
            move(pictureBox_blackpawn4, BlackPawn4_selected, BlackPawn4_xy, f6c);
            move(pictureBox_blackpawn5, BlackPawn5_selected, BlackPawn5_xy, f6c);
            move(pictureBox_blackpawn6, BlackPawn6_selected, BlackPawn6_xy, f6c);
            move(pictureBox_blackpawn7, BlackPawn7_selected, BlackPawn7_xy, f6c);
            move(pictureBox_blackpawn8, BlackPawn8_selected, BlackPawn8_xy, f6c);
            move(pictureBox_blackrook1, BlackRook1_selected, BlackRook1_xy, f6c);
            move(pictureBox_blackknight1, BlackKnight1_selected, BlackKnight1_xy, f6c);
            move(pictureBox_blackbishop1, BlackBishop1_selected, BlackBishop1_xy, f6c);
            move(pictureBox_blackqueen, BlackQueen_selected, BlackQueen_xy, f6c);
            move(pictureBox_blackking, BlackKing_selected, BlackKing_xy, f6c);
            move(pictureBox_blackbishop2, BlackBishop2_selected, BlackBishop2_xy, f6c);
            move(pictureBox_blackknight2, BlackKnight2_selected, BlackKnight2_xy, f6c);
            move(pictureBox_blackrook2, BlackRook2_selected, BlackRook2_xy, f6c);

            move(pictureBox_whitepawn1, WhitePawn1_selected, WhitePawn1_xy, f6c);
            move(pictureBox_whitepawn2, WhitePawn2_selected, WhitePawn2_xy, f6c);
            move(pictureBox_whitepawn3, WhitePawn3_selected, WhitePawn3_xy, f6c);
            move(pictureBox_whitepawn4, WhitePawn4_selected, WhitePawn4_xy, f6c);
            move(pictureBox_whitepawn5, WhitePawn5_selected, WhitePawn5_xy, f6c);
            move(pictureBox_whitepawn6, WhitePawn6_selected, WhitePawn6_xy, f6c);
            move(pictureBox_whitepawn7, WhitePawn7_selected, WhitePawn7_xy, f6c);
            move(pictureBox_whitepawn8, WhitePawn8_selected, WhitePawn8_xy, f6c);
            move(pictureBox_whiterook1, WhiteRook1_selected, WhiteRook1_xy, f6c);
            move(pictureBox_whiteknight1, WhiteKnight1_selected, WhiteKnight1_xy, f6c);
            move(pictureBox_whitebishop1, WhiteBishop1_selected, WhiteBishop1_xy, f6c);
            move(pictureBox_whitequeen, WhiteQueen_selected, WhiteQueen_xy, f6c);
            move(pictureBox_whiteking, WhiteKing_selected, WhiteKing_xy, f6c);
            move(pictureBox_whitebishop2, WhiteBishop2_selected, WhiteBishop2_xy, f6c);
            move(pictureBox_whiteknight2, WhiteKnight2_selected, WhiteKnight2_xy, f6c);
            move(pictureBox_whiterook2, WhiteRook2_selected, WhiteRook2_xy, f6c);
        }

        private void pictureBox_f7_Click(object sender, EventArgs e)

        {
            move(pictureBox_blackpawn1, BlackPawn1_selected, BlackPawn1_xy, f7c);
            move(pictureBox_blackpawn2, BlackPawn2_selected, BlackPawn2_xy, f7c);
            move(pictureBox_blackpawn3, BlackPawn3_selected, BlackPawn3_xy, f7c);
            move(pictureBox_blackpawn4, BlackPawn4_selected, BlackPawn4_xy, f7c);
            move(pictureBox_blackpawn5, BlackPawn5_selected, BlackPawn5_xy, f7c);
            move(pictureBox_blackpawn6, BlackPawn6_selected, BlackPawn6_xy, f7c);
            move(pictureBox_blackpawn7, BlackPawn7_selected, BlackPawn7_xy, f7c);
            move(pictureBox_blackpawn8, BlackPawn8_selected, BlackPawn8_xy, f7c);
            move(pictureBox_blackrook1, BlackRook1_selected, BlackRook1_xy, f7c);
            move(pictureBox_blackknight1, BlackKnight1_selected, BlackKnight1_xy, f7c);
            move(pictureBox_blackbishop1, BlackBishop1_selected, BlackBishop1_xy, f7c);
            move(pictureBox_blackqueen, BlackQueen_selected, BlackQueen_xy, f7c);
            move(pictureBox_blackking, BlackKing_selected, BlackKing_xy, f7c);
            move(pictureBox_blackbishop2, BlackBishop2_selected, BlackBishop2_xy, f7c);
            move(pictureBox_blackknight2, BlackKnight2_selected, BlackKnight2_xy, f7c);
            move(pictureBox_blackrook2, BlackRook2_selected, BlackRook2_xy, f7c);

            move(pictureBox_whitepawn1, WhitePawn1_selected, WhitePawn1_xy, f7c);
            move(pictureBox_whitepawn2, WhitePawn2_selected, WhitePawn2_xy, f7c);
            move(pictureBox_whitepawn3, WhitePawn3_selected, WhitePawn3_xy, f7c);
            move(pictureBox_whitepawn4, WhitePawn4_selected, WhitePawn4_xy, f7c);
            move(pictureBox_whitepawn5, WhitePawn5_selected, WhitePawn5_xy, f7c);
            move(pictureBox_whitepawn6, WhitePawn6_selected, WhitePawn6_xy, f7c);
            move(pictureBox_whitepawn7, WhitePawn7_selected, WhitePawn7_xy, f7c);
            move(pictureBox_whitepawn8, WhitePawn8_selected, WhitePawn8_xy, f7c);
            move(pictureBox_whiterook1, WhiteRook1_selected, WhiteRook1_xy, f7c);
            move(pictureBox_whiteknight1, WhiteKnight1_selected, WhiteKnight1_xy, f7c);
            move(pictureBox_whitebishop1, WhiteBishop1_selected, WhiteBishop1_xy, f7c);
            move(pictureBox_whitequeen, WhiteQueen_selected, WhiteQueen_xy, f7c);
            move(pictureBox_whiteking, WhiteKing_selected, WhiteKing_xy, f7c);
            move(pictureBox_whitebishop2, WhiteBishop2_selected, WhiteBishop2_xy, f7c);
            move(pictureBox_whiteknight2, WhiteKnight2_selected, WhiteKnight2_xy, f7c);
            move(pictureBox_whiterook2, WhiteRook2_selected, WhiteRook2_xy, f7c);
        }

        private void pictureBox_f8_Click(object sender, EventArgs e)

        {
            move(pictureBox_blackpawn1, BlackPawn1_selected, BlackPawn1_xy, f8c);
            move(pictureBox_blackpawn2, BlackPawn2_selected, BlackPawn2_xy, f8c);
            move(pictureBox_blackpawn3, BlackPawn3_selected, BlackPawn3_xy, f8c);
            move(pictureBox_blackpawn4, BlackPawn4_selected, BlackPawn4_xy, f8c);
            move(pictureBox_blackpawn5, BlackPawn5_selected, BlackPawn5_xy, f8c);
            move(pictureBox_blackpawn6, BlackPawn6_selected, BlackPawn6_xy, f8c);
            move(pictureBox_blackpawn7, BlackPawn7_selected, BlackPawn7_xy, f8c);
            move(pictureBox_blackpawn8, BlackPawn8_selected, BlackPawn8_xy, f8c);
            move(pictureBox_blackrook1, BlackRook1_selected, BlackRook1_xy, f8c);
            move(pictureBox_blackknight1, BlackKnight1_selected, BlackKnight1_xy, f8c);
            move(pictureBox_blackbishop1, BlackBishop1_selected, BlackBishop1_xy, f8c);
            move(pictureBox_blackqueen, BlackQueen_selected, BlackQueen_xy, f8c);
            move(pictureBox_blackking, BlackKing_selected, BlackKing_xy, f8c);
            move(pictureBox_blackbishop2, BlackBishop2_selected, BlackBishop2_xy, f8c);
            move(pictureBox_blackknight2, BlackKnight2_selected, BlackKnight2_xy, f8c);
            move(pictureBox_blackrook2, BlackRook2_selected, BlackRook2_xy, f8c);

            move(pictureBox_whitepawn1, WhitePawn1_selected, WhitePawn1_xy, f8c);
            move(pictureBox_whitepawn2, WhitePawn2_selected, WhitePawn2_xy, f8c);
            move(pictureBox_whitepawn3, WhitePawn3_selected, WhitePawn3_xy, f8c);
            move(pictureBox_whitepawn4, WhitePawn4_selected, WhitePawn4_xy, f8c);
            move(pictureBox_whitepawn5, WhitePawn5_selected, WhitePawn5_xy, f8c);
            move(pictureBox_whitepawn6, WhitePawn6_selected, WhitePawn6_xy, f8c);
            move(pictureBox_whitepawn7, WhitePawn7_selected, WhitePawn7_xy, f8c);
            move(pictureBox_whitepawn8, WhitePawn8_selected, WhitePawn8_xy, f8c);
            move(pictureBox_whiterook1, WhiteRook1_selected, WhiteRook1_xy, f8c);
            move(pictureBox_whiteknight1, WhiteKnight1_selected, WhiteKnight1_xy, f8c);
            move(pictureBox_whitebishop1, WhiteBishop1_selected, WhiteBishop1_xy, f8c);
            move(pictureBox_whitequeen, WhiteQueen_selected, WhiteQueen_xy, f8c);
            move(pictureBox_whiteking, WhiteKing_selected, WhiteKing_xy, f8c);
            move(pictureBox_whitebishop2, WhiteBishop2_selected, WhiteBishop2_xy, f8c);
            move(pictureBox_whiteknight2, WhiteKnight2_selected, WhiteKnight2_xy, f8c);
            move(pictureBox_whiterook2, WhiteRook2_selected, WhiteRook2_xy, f8c);
        }


        private void pictureBox_g1_Click(object sender, EventArgs e)

        {
            move(pictureBox_blackpawn1, BlackPawn1_selected, BlackPawn1_xy, g1c);
            move(pictureBox_blackpawn2, BlackPawn2_selected, BlackPawn2_xy, g1c);
            move(pictureBox_blackpawn3, BlackPawn3_selected, BlackPawn3_xy, g1c);
            move(pictureBox_blackpawn4, BlackPawn4_selected, BlackPawn4_xy, g1c);
            move(pictureBox_blackpawn5, BlackPawn5_selected, BlackPawn5_xy, g1c);
            move(pictureBox_blackpawn6, BlackPawn6_selected, BlackPawn6_xy, g1c);
            move(pictureBox_blackpawn7, BlackPawn7_selected, BlackPawn7_xy, g1c);
            move(pictureBox_blackpawn8, BlackPawn8_selected, BlackPawn8_xy, g1c);
            move(pictureBox_blackrook1, BlackRook1_selected, BlackRook1_xy, g1c);
            move(pictureBox_blackknight1, BlackKnight1_selected, BlackKnight1_xy, g1c);
            move(pictureBox_blackbishop1, BlackBishop1_selected, BlackBishop1_xy, g1c);
            move(pictureBox_blackqueen, BlackQueen_selected, BlackQueen_xy, g1c);
            move(pictureBox_blackking, BlackKing_selected, BlackKing_xy, g1c);
            move(pictureBox_blackbishop2, BlackBishop2_selected, BlackBishop2_xy, g1c);
            move(pictureBox_blackknight2, BlackKnight2_selected, BlackKnight2_xy, g1c);
            move(pictureBox_blackrook2, BlackRook2_selected, BlackRook2_xy, g1c);

            move(pictureBox_whitepawn1, WhitePawn1_selected, WhitePawn1_xy, g1c);
            move(pictureBox_whitepawn2, WhitePawn2_selected, WhitePawn2_xy, g1c);
            move(pictureBox_whitepawn3, WhitePawn3_selected, WhitePawn3_xy, g1c);
            move(pictureBox_whitepawn4, WhitePawn4_selected, WhitePawn4_xy, g1c);
            move(pictureBox_whitepawn5, WhitePawn5_selected, WhitePawn5_xy, g1c);
            move(pictureBox_whitepawn6, WhitePawn6_selected, WhitePawn6_xy, g1c);
            move(pictureBox_whitepawn7, WhitePawn7_selected, WhitePawn7_xy, g1c);
            move(pictureBox_whitepawn8, WhitePawn8_selected, WhitePawn8_xy, g1c);
            move(pictureBox_whiterook1, WhiteRook1_selected, WhiteRook1_xy, g1c);
            move(pictureBox_whiteknight1, WhiteKnight1_selected, WhiteKnight1_xy, g1c);
            move(pictureBox_whitebishop1, WhiteBishop1_selected, WhiteBishop1_xy, g1c);
            move(pictureBox_whitequeen, WhiteQueen_selected, WhiteQueen_xy, g1c);
            move(pictureBox_whiteking, WhiteKing_selected, WhiteKing_xy, g1c);
            move(pictureBox_whitebishop2, WhiteBishop2_selected, WhiteBishop2_xy, g1c);
            move(pictureBox_whiteknight2, WhiteKnight2_selected, WhiteKnight2_xy, g1c);
            move(pictureBox_whiterook2, WhiteRook2_selected, WhiteRook2_xy, g1c);
        }

        private void pictureBox_g2_Click(object sender, EventArgs e)

        {
            move(pictureBox_blackpawn1, BlackPawn1_selected, BlackPawn1_xy, g2c);
            move(pictureBox_blackpawn2, BlackPawn2_selected, BlackPawn2_xy, g2c);
            move(pictureBox_blackpawn3, BlackPawn3_selected, BlackPawn3_xy, g2c);
            move(pictureBox_blackpawn4, BlackPawn4_selected, BlackPawn4_xy, g2c);
            move(pictureBox_blackpawn5, BlackPawn5_selected, BlackPawn5_xy, g2c);
            move(pictureBox_blackpawn6, BlackPawn6_selected, BlackPawn6_xy, g2c);
            move(pictureBox_blackpawn7, BlackPawn7_selected, BlackPawn7_xy, g2c);
            move(pictureBox_blackpawn8, BlackPawn8_selected, BlackPawn8_xy, g2c);
            move(pictureBox_blackrook1, BlackRook1_selected, BlackRook1_xy, g2c);
            move(pictureBox_blackknight1, BlackKnight1_selected, BlackKnight1_xy, g2c);
            move(pictureBox_blackbishop1, BlackBishop1_selected, BlackBishop1_xy, g2c);
            move(pictureBox_blackqueen, BlackQueen_selected, BlackQueen_xy, g2c);
            move(pictureBox_blackking, BlackKing_selected, BlackKing_xy, g2c);
            move(pictureBox_blackbishop2, BlackBishop2_selected, BlackBishop2_xy, g2c);
            move(pictureBox_blackknight2, BlackKnight2_selected, BlackKnight2_xy, g2c);
            move(pictureBox_blackrook2, BlackRook2_selected, BlackRook2_xy, g2c);

            move(pictureBox_whitepawn1, WhitePawn1_selected, WhitePawn1_xy, g2c);
            move(pictureBox_whitepawn2, WhitePawn2_selected, WhitePawn2_xy, g2c);
            move(pictureBox_whitepawn3, WhitePawn3_selected, WhitePawn3_xy, g2c);
            move(pictureBox_whitepawn4, WhitePawn4_selected, WhitePawn4_xy, g2c);
            move(pictureBox_whitepawn5, WhitePawn5_selected, WhitePawn5_xy, g2c);
            move(pictureBox_whitepawn6, WhitePawn6_selected, WhitePawn6_xy, g2c);
            move(pictureBox_whitepawn7, WhitePawn7_selected, WhitePawn7_xy, g2c);
            move(pictureBox_whitepawn8, WhitePawn8_selected, WhitePawn8_xy, g2c);
            move(pictureBox_whiterook1, WhiteRook1_selected, WhiteRook1_xy, g2c);
            move(pictureBox_whiteknight1, WhiteKnight1_selected, WhiteKnight1_xy, g2c);
            move(pictureBox_whitebishop1, WhiteBishop1_selected, WhiteBishop1_xy, g2c);
            move(pictureBox_whitequeen, WhiteQueen_selected, WhiteQueen_xy, g2c);
            move(pictureBox_whiteking, WhiteKing_selected, WhiteKing_xy, g2c);
            move(pictureBox_whitebishop2, WhiteBishop2_selected, WhiteBishop2_xy, g2c);
            move(pictureBox_whiteknight2, WhiteKnight2_selected, WhiteKnight2_xy, g2c);
            move(pictureBox_whiterook2, WhiteRook2_selected, WhiteRook2_xy, g2c);
        }

        private void pictureBox_g3_Click(object sender, EventArgs e)

        {
            move(pictureBox_blackpawn1, BlackPawn1_selected, BlackPawn1_xy, g3c);
            move(pictureBox_blackpawn2, BlackPawn2_selected, BlackPawn2_xy, g3c);
            move(pictureBox_blackpawn3, BlackPawn3_selected, BlackPawn3_xy, g3c);
            move(pictureBox_blackpawn4, BlackPawn4_selected, BlackPawn4_xy, g3c);
            move(pictureBox_blackpawn5, BlackPawn5_selected, BlackPawn5_xy, g3c);
            move(pictureBox_blackpawn6, BlackPawn6_selected, BlackPawn6_xy, g3c);
            move(pictureBox_blackpawn7, BlackPawn7_selected, BlackPawn7_xy, g3c);
            move(pictureBox_blackpawn8, BlackPawn8_selected, BlackPawn8_xy, g3c);
            move(pictureBox_blackrook1, BlackRook1_selected, BlackRook1_xy, g3c);
            move(pictureBox_blackknight1, BlackKnight1_selected, BlackKnight1_xy, g3c);
            move(pictureBox_blackbishop1, BlackBishop1_selected, BlackBishop1_xy, g3c);
            move(pictureBox_blackqueen, BlackQueen_selected, BlackQueen_xy, g3c);
            move(pictureBox_blackking, BlackKing_selected, BlackKing_xy, g3c);
            move(pictureBox_blackbishop2, BlackBishop2_selected, BlackBishop2_xy, g3c);
            move(pictureBox_blackknight2, BlackKnight2_selected, BlackKnight2_xy, g3c);
            move(pictureBox_blackrook2, BlackRook2_selected, BlackRook2_xy, g3c);

            move(pictureBox_whitepawn1, WhitePawn1_selected, WhitePawn1_xy, g3c);
            move(pictureBox_whitepawn2, WhitePawn2_selected, WhitePawn2_xy, g3c);
            move(pictureBox_whitepawn3, WhitePawn3_selected, WhitePawn3_xy, g3c);
            move(pictureBox_whitepawn4, WhitePawn4_selected, WhitePawn4_xy, g3c);
            move(pictureBox_whitepawn5, WhitePawn5_selected, WhitePawn5_xy, g3c);
            move(pictureBox_whitepawn6, WhitePawn6_selected, WhitePawn6_xy, g3c);
            move(pictureBox_whitepawn7, WhitePawn7_selected, WhitePawn7_xy, g3c);
            move(pictureBox_whitepawn8, WhitePawn8_selected, WhitePawn8_xy, g3c);
            move(pictureBox_whiterook1, WhiteRook1_selected, WhiteRook1_xy, g3c);
            move(pictureBox_whiteknight1, WhiteKnight1_selected, WhiteKnight1_xy, g3c);
            move(pictureBox_whitebishop1, WhiteBishop1_selected, WhiteBishop1_xy, g3c);
            move(pictureBox_whitequeen, WhiteQueen_selected, WhiteQueen_xy, g3c);
            move(pictureBox_whiteking, WhiteKing_selected, WhiteKing_xy, g3c);
            move(pictureBox_whitebishop2, WhiteBishop2_selected, WhiteBishop2_xy, g3c);
            move(pictureBox_whiteknight2, WhiteKnight2_selected, WhiteKnight2_xy, g3c);
            move(pictureBox_whiterook2, WhiteRook2_selected, WhiteRook2_xy, g3c);
        }

        private void pictureBox_g4_Click(object sender, EventArgs e)

        {
            move(pictureBox_blackpawn1, BlackPawn1_selected, BlackPawn1_xy, g4c);
            move(pictureBox_blackpawn2, BlackPawn2_selected, BlackPawn2_xy, g4c);
            move(pictureBox_blackpawn3, BlackPawn3_selected, BlackPawn3_xy, g4c);
            move(pictureBox_blackpawn4, BlackPawn4_selected, BlackPawn4_xy, g4c);
            move(pictureBox_blackpawn5, BlackPawn5_selected, BlackPawn5_xy, g4c);
            move(pictureBox_blackpawn6, BlackPawn6_selected, BlackPawn6_xy, g4c);
            move(pictureBox_blackpawn7, BlackPawn7_selected, BlackPawn7_xy, g4c);
            move(pictureBox_blackpawn8, BlackPawn8_selected, BlackPawn8_xy, g4c);
            move(pictureBox_blackrook1, BlackRook1_selected, BlackRook1_xy, g4c);
            move(pictureBox_blackknight1, BlackKnight1_selected, BlackKnight1_xy, g4c);
            move(pictureBox_blackbishop1, BlackBishop1_selected, BlackBishop1_xy, g4c);
            move(pictureBox_blackqueen, BlackQueen_selected, BlackQueen_xy, g4c);
            move(pictureBox_blackking, BlackKing_selected, BlackKing_xy, g4c);
            move(pictureBox_blackbishop2, BlackBishop2_selected, BlackBishop2_xy, g4c);
            move(pictureBox_blackknight2, BlackKnight2_selected, BlackKnight2_xy, g4c);
            move(pictureBox_blackrook2, BlackRook2_selected, BlackRook2_xy, g4c);

            move(pictureBox_whitepawn1, WhitePawn1_selected, WhitePawn1_xy, g4c);
            move(pictureBox_whitepawn2, WhitePawn2_selected, WhitePawn2_xy, g4c);
            move(pictureBox_whitepawn3, WhitePawn3_selected, WhitePawn3_xy, g4c);
            move(pictureBox_whitepawn4, WhitePawn4_selected, WhitePawn4_xy, g4c);
            move(pictureBox_whitepawn5, WhitePawn5_selected, WhitePawn5_xy, g4c);
            move(pictureBox_whitepawn6, WhitePawn6_selected, WhitePawn6_xy, g4c);
            move(pictureBox_whitepawn7, WhitePawn7_selected, WhitePawn7_xy, g4c);
            move(pictureBox_whitepawn8, WhitePawn8_selected, WhitePawn8_xy, g4c);
            move(pictureBox_whiterook1, WhiteRook1_selected, WhiteRook1_xy, g4c);
            move(pictureBox_whiteknight1, WhiteKnight1_selected, WhiteKnight1_xy, g4c);
            move(pictureBox_whitebishop1, WhiteBishop1_selected, WhiteBishop1_xy, g4c);
            move(pictureBox_whitequeen, WhiteQueen_selected, WhiteQueen_xy, g4c);
            move(pictureBox_whiteking, WhiteKing_selected, WhiteKing_xy, g4c);
            move(pictureBox_whitebishop2, WhiteBishop2_selected, WhiteBishop2_xy, g4c);
            move(pictureBox_whiteknight2, WhiteKnight2_selected, WhiteKnight2_xy, g4c);
            move(pictureBox_whiterook2, WhiteRook2_selected, WhiteRook2_xy, g4c);
        }

        private void pictureBox_g5_Click(object sender, EventArgs e)

        {
            move(pictureBox_blackpawn1, BlackPawn1_selected, BlackPawn1_xy, g5c);
            move(pictureBox_blackpawn2, BlackPawn2_selected, BlackPawn2_xy, g5c);
            move(pictureBox_blackpawn3, BlackPawn3_selected, BlackPawn3_xy, g5c);
            move(pictureBox_blackpawn4, BlackPawn4_selected, BlackPawn4_xy, g5c);
            move(pictureBox_blackpawn5, BlackPawn5_selected, BlackPawn5_xy, g5c);
            move(pictureBox_blackpawn6, BlackPawn6_selected, BlackPawn6_xy, g5c);
            move(pictureBox_blackpawn7, BlackPawn7_selected, BlackPawn7_xy, g5c);
            move(pictureBox_blackpawn8, BlackPawn8_selected, BlackPawn8_xy, g5c);
            move(pictureBox_blackrook1, BlackRook1_selected, BlackRook1_xy, g5c);
            move(pictureBox_blackknight1, BlackKnight1_selected, BlackKnight1_xy, g5c);
            move(pictureBox_blackbishop1, BlackBishop1_selected, BlackBishop1_xy, g5c);
            move(pictureBox_blackqueen, BlackQueen_selected, BlackQueen_xy, g5c);
            move(pictureBox_blackking, BlackKing_selected, BlackKing_xy, g5c);
            move(pictureBox_blackbishop2, BlackBishop2_selected, BlackBishop2_xy, g5c);
            move(pictureBox_blackknight2, BlackKnight2_selected, BlackKnight2_xy, g5c);
            move(pictureBox_blackrook2, BlackRook2_selected, BlackRook2_xy, g5c);

            move(pictureBox_whitepawn1, WhitePawn1_selected, WhitePawn1_xy, g5c);
            move(pictureBox_whitepawn2, WhitePawn2_selected, WhitePawn2_xy, g5c);
            move(pictureBox_whitepawn3, WhitePawn3_selected, WhitePawn3_xy, g5c);
            move(pictureBox_whitepawn4, WhitePawn4_selected, WhitePawn4_xy, g5c);
            move(pictureBox_whitepawn5, WhitePawn5_selected, WhitePawn5_xy, g5c);
            move(pictureBox_whitepawn6, WhitePawn6_selected, WhitePawn6_xy, g5c);
            move(pictureBox_whitepawn7, WhitePawn7_selected, WhitePawn7_xy, g5c);
            move(pictureBox_whitepawn8, WhitePawn8_selected, WhitePawn8_xy, g5c);
            move(pictureBox_whiterook1, WhiteRook1_selected, WhiteRook1_xy, g5c);
            move(pictureBox_whiteknight1, WhiteKnight1_selected, WhiteKnight1_xy, g5c);
            move(pictureBox_whitebishop1, WhiteBishop1_selected, WhiteBishop1_xy, g5c);
            move(pictureBox_whitequeen, WhiteQueen_selected, WhiteQueen_xy, g5c);
            move(pictureBox_whiteking, WhiteKing_selected, WhiteKing_xy, g5c);
            move(pictureBox_whitebishop2, WhiteBishop2_selected, WhiteBishop2_xy, g5c);
            move(pictureBox_whiteknight2, WhiteKnight2_selected, WhiteKnight2_xy, g5c);
            move(pictureBox_whiterook2, WhiteRook2_selected, WhiteRook2_xy, g5c);
        }

        private void pictureBox_g6_Click(object sender, EventArgs e)

        {
            move(pictureBox_blackpawn1, BlackPawn1_selected, BlackPawn1_xy, g6c);
            move(pictureBox_blackpawn2, BlackPawn2_selected, BlackPawn2_xy, g6c);
            move(pictureBox_blackpawn3, BlackPawn3_selected, BlackPawn3_xy, g6c);
            move(pictureBox_blackpawn4, BlackPawn4_selected, BlackPawn4_xy, g6c);
            move(pictureBox_blackpawn5, BlackPawn5_selected, BlackPawn5_xy, g6c);
            move(pictureBox_blackpawn6, BlackPawn6_selected, BlackPawn6_xy, g6c);
            move(pictureBox_blackpawn7, BlackPawn7_selected, BlackPawn7_xy, g6c);
            move(pictureBox_blackpawn8, BlackPawn8_selected, BlackPawn8_xy, g6c);
            move(pictureBox_blackrook1, BlackRook1_selected, BlackRook1_xy, g6c);
            move(pictureBox_blackknight1, BlackKnight1_selected, BlackKnight1_xy, g6c);
            move(pictureBox_blackbishop1, BlackBishop1_selected, BlackBishop1_xy, g6c);
            move(pictureBox_blackqueen, BlackQueen_selected, BlackQueen_xy, g6c);
            move(pictureBox_blackking, BlackKing_selected, BlackKing_xy, g6c);
            move(pictureBox_blackbishop2, BlackBishop2_selected, BlackBishop2_xy, g6c);
            move(pictureBox_blackknight2, BlackKnight2_selected, BlackKnight2_xy, g6c);
            move(pictureBox_blackrook2, BlackRook2_selected, BlackRook2_xy, g6c);

            move(pictureBox_whitepawn1, WhitePawn1_selected, WhitePawn1_xy, g6c);
            move(pictureBox_whitepawn2, WhitePawn2_selected, WhitePawn2_xy, g6c);
            move(pictureBox_whitepawn3, WhitePawn3_selected, WhitePawn3_xy, g6c);
            move(pictureBox_whitepawn4, WhitePawn4_selected, WhitePawn4_xy, g6c);
            move(pictureBox_whitepawn5, WhitePawn5_selected, WhitePawn5_xy, g6c);
            move(pictureBox_whitepawn6, WhitePawn6_selected, WhitePawn6_xy, g6c);
            move(pictureBox_whitepawn7, WhitePawn7_selected, WhitePawn7_xy, g6c);
            move(pictureBox_whitepawn8, WhitePawn8_selected, WhitePawn8_xy, g6c);
            move(pictureBox_whiterook1, WhiteRook1_selected, WhiteRook1_xy, g6c);
            move(pictureBox_whiteknight1, WhiteKnight1_selected, WhiteKnight1_xy, g6c);
            move(pictureBox_whitebishop1, WhiteBishop1_selected, WhiteBishop1_xy, g6c);
            move(pictureBox_whitequeen, WhiteQueen_selected, WhiteQueen_xy, g6c);
            move(pictureBox_whiteking, WhiteKing_selected, WhiteKing_xy, g6c);
            move(pictureBox_whitebishop2, WhiteBishop2_selected, WhiteBishop2_xy, g6c);
            move(pictureBox_whiteknight2, WhiteKnight2_selected, WhiteKnight2_xy, g6c);
            move(pictureBox_whiterook2, WhiteRook2_selected, WhiteRook2_xy, g6c);
        }

        private void pictureBox_g7_Click(object sender, EventArgs e)

        {
            move(pictureBox_blackpawn1, BlackPawn1_selected, BlackPawn1_xy, g7c);
            move(pictureBox_blackpawn2, BlackPawn2_selected, BlackPawn2_xy, g7c);
            move(pictureBox_blackpawn3, BlackPawn3_selected, BlackPawn3_xy, g7c);
            move(pictureBox_blackpawn4, BlackPawn4_selected, BlackPawn4_xy, g7c);
            move(pictureBox_blackpawn5, BlackPawn5_selected, BlackPawn5_xy, g7c);
            move(pictureBox_blackpawn6, BlackPawn6_selected, BlackPawn6_xy, g7c);
            move(pictureBox_blackpawn7, BlackPawn7_selected, BlackPawn7_xy, g7c);
            move(pictureBox_blackpawn8, BlackPawn8_selected, BlackPawn8_xy, g7c);
            move(pictureBox_blackrook1, BlackRook1_selected, BlackRook1_xy, g7c);
            move(pictureBox_blackknight1, BlackKnight1_selected, BlackKnight1_xy, g7c);
            move(pictureBox_blackbishop1, BlackBishop1_selected, BlackBishop1_xy, g7c);
            move(pictureBox_blackqueen, BlackQueen_selected, BlackQueen_xy, g7c);
            move(pictureBox_blackking, BlackKing_selected, BlackKing_xy, g7c);
            move(pictureBox_blackbishop2, BlackBishop2_selected, BlackBishop2_xy, g7c);
            move(pictureBox_blackknight2, BlackKnight2_selected, BlackKnight2_xy, g7c);
            move(pictureBox_blackrook2, BlackRook2_selected, BlackRook2_xy, g7c);

            move(pictureBox_whitepawn1, WhitePawn1_selected, WhitePawn1_xy, g7c);
            move(pictureBox_whitepawn2, WhitePawn2_selected, WhitePawn2_xy, g7c);
            move(pictureBox_whitepawn3, WhitePawn3_selected, WhitePawn3_xy, g7c);
            move(pictureBox_whitepawn4, WhitePawn4_selected, WhitePawn4_xy, g7c);
            move(pictureBox_whitepawn5, WhitePawn5_selected, WhitePawn5_xy, g7c);
            move(pictureBox_whitepawn6, WhitePawn6_selected, WhitePawn6_xy, g7c);
            move(pictureBox_whitepawn7, WhitePawn7_selected, WhitePawn7_xy, g7c);
            move(pictureBox_whitepawn8, WhitePawn8_selected, WhitePawn8_xy, g7c);
            move(pictureBox_whiterook1, WhiteRook1_selected, WhiteRook1_xy, g7c);
            move(pictureBox_whiteknight1, WhiteKnight1_selected, WhiteKnight1_xy, g7c);
            move(pictureBox_whitebishop1, WhiteBishop1_selected, WhiteBishop1_xy, g7c);
            move(pictureBox_whitequeen, WhiteQueen_selected, WhiteQueen_xy, g7c);
            move(pictureBox_whiteking, WhiteKing_selected, WhiteKing_xy, g7c);
            move(pictureBox_whitebishop2, WhiteBishop2_selected, WhiteBishop2_xy, g7c);
            move(pictureBox_whiteknight2, WhiteKnight2_selected, WhiteKnight2_xy, g7c);
            move(pictureBox_whiterook2, WhiteRook2_selected, WhiteRook2_xy, g7c);
        }

        private void pictureBox_g8_Click(object sender, EventArgs e)

        {
            move(pictureBox_blackpawn1, BlackPawn1_selected, BlackPawn1_xy, g8c);
            move(pictureBox_blackpawn2, BlackPawn2_selected, BlackPawn2_xy, g8c);
            move(pictureBox_blackpawn3, BlackPawn3_selected, BlackPawn3_xy, g8c);
            move(pictureBox_blackpawn4, BlackPawn4_selected, BlackPawn4_xy, g8c);
            move(pictureBox_blackpawn5, BlackPawn5_selected, BlackPawn5_xy, g8c);
            move(pictureBox_blackpawn6, BlackPawn6_selected, BlackPawn6_xy, g8c);
            move(pictureBox_blackpawn7, BlackPawn7_selected, BlackPawn7_xy, g8c);
            move(pictureBox_blackpawn8, BlackPawn8_selected, BlackPawn8_xy, g8c);
            move(pictureBox_blackrook1, BlackRook1_selected, BlackRook1_xy, g8c);
            move(pictureBox_blackknight1, BlackKnight1_selected, BlackKnight1_xy, g8c);
            move(pictureBox_blackbishop1, BlackBishop1_selected, BlackBishop1_xy, g8c);
            move(pictureBox_blackqueen, BlackQueen_selected, BlackQueen_xy, g8c);
            move(pictureBox_blackking, BlackKing_selected, BlackKing_xy, g8c);
            move(pictureBox_blackbishop2, BlackBishop2_selected, BlackBishop2_xy, g8c);
            move(pictureBox_blackknight2, BlackKnight2_selected, BlackKnight2_xy, g8c);
            move(pictureBox_blackrook2, BlackRook2_selected, BlackRook2_xy, g8c);

            move(pictureBox_whitepawn1, WhitePawn1_selected, WhitePawn1_xy, g8c);
            move(pictureBox_whitepawn2, WhitePawn2_selected, WhitePawn2_xy, g8c);
            move(pictureBox_whitepawn3, WhitePawn3_selected, WhitePawn3_xy, g8c);
            move(pictureBox_whitepawn4, WhitePawn4_selected, WhitePawn4_xy, g8c);
            move(pictureBox_whitepawn5, WhitePawn5_selected, WhitePawn5_xy, g8c);
            move(pictureBox_whitepawn6, WhitePawn6_selected, WhitePawn6_xy, g8c);
            move(pictureBox_whitepawn7, WhitePawn7_selected, WhitePawn7_xy, g8c);
            move(pictureBox_whitepawn8, WhitePawn8_selected, WhitePawn8_xy, g8c);
            move(pictureBox_whiterook1, WhiteRook1_selected, WhiteRook1_xy, g8c);
            move(pictureBox_whiteknight1, WhiteKnight1_selected, WhiteKnight1_xy, g8c);
            move(pictureBox_whitebishop1, WhiteBishop1_selected, WhiteBishop1_xy, g8c);
            move(pictureBox_whitequeen, WhiteQueen_selected, WhiteQueen_xy, g8c);
            move(pictureBox_whiteking, WhiteKing_selected, WhiteKing_xy, g8c);
            move(pictureBox_whitebishop2, WhiteBishop2_selected, WhiteBishop2_xy, g8c);
            move(pictureBox_whiteknight2, WhiteKnight2_selected, WhiteKnight2_xy, g8c);
            move(pictureBox_whiterook2, WhiteRook2_selected, WhiteRook2_xy, g8c);
        }


        private void pictureBox_h1_Click(object sender, EventArgs e)

        {
            move(pictureBox_blackpawn1, BlackPawn1_selected, BlackPawn1_xy, h1c);
            move(pictureBox_blackpawn2, BlackPawn2_selected, BlackPawn2_xy, h1c);
            move(pictureBox_blackpawn3, BlackPawn3_selected, BlackPawn3_xy, h1c);
            move(pictureBox_blackpawn4, BlackPawn4_selected, BlackPawn4_xy, h1c);
            move(pictureBox_blackpawn5, BlackPawn5_selected, BlackPawn5_xy, h1c);
            move(pictureBox_blackpawn6, BlackPawn6_selected, BlackPawn6_xy, h1c);
            move(pictureBox_blackpawn7, BlackPawn7_selected, BlackPawn7_xy, h1c);
            move(pictureBox_blackpawn8, BlackPawn8_selected, BlackPawn8_xy, h1c);
            move(pictureBox_blackrook1, BlackRook1_selected, BlackRook1_xy, h1c);
            move(pictureBox_blackknight1, BlackKnight1_selected, BlackKnight1_xy, h1c);
            move(pictureBox_blackbishop1, BlackBishop1_selected, BlackBishop1_xy, h1c);
            move(pictureBox_blackqueen, BlackQueen_selected, BlackQueen_xy, h1c);
            move(pictureBox_blackking, BlackKing_selected, BlackKing_xy, h1c);
            move(pictureBox_blackbishop2, BlackBishop2_selected, BlackBishop2_xy, h1c);
            move(pictureBox_blackknight2, BlackKnight2_selected, BlackKnight2_xy, h1c);
            move(pictureBox_blackrook2, BlackRook2_selected, BlackRook2_xy, h1c);

            move(pictureBox_whitepawn1, WhitePawn1_selected, WhitePawn1_xy, h1c);
            move(pictureBox_whitepawn2, WhitePawn2_selected, WhitePawn2_xy, h1c);
            move(pictureBox_whitepawn3, WhitePawn3_selected, WhitePawn3_xy, h1c);
            move(pictureBox_whitepawn4, WhitePawn4_selected, WhitePawn4_xy, h1c);
            move(pictureBox_whitepawn5, WhitePawn5_selected, WhitePawn5_xy, h1c);
            move(pictureBox_whitepawn6, WhitePawn6_selected, WhitePawn6_xy, h1c);
            move(pictureBox_whitepawn7, WhitePawn7_selected, WhitePawn7_xy, h1c);
            move(pictureBox_whitepawn8, WhitePawn8_selected, WhitePawn8_xy, h1c);
            move(pictureBox_whiterook1, WhiteRook1_selected, WhiteRook1_xy, h1c);
            move(pictureBox_whiteknight1, WhiteKnight1_selected, WhiteKnight1_xy, h1c);
            move(pictureBox_whitebishop1, WhiteBishop1_selected, WhiteBishop1_xy, h1c);
            move(pictureBox_whitequeen, WhiteQueen_selected, WhiteQueen_xy, h1c);
            move(pictureBox_whiteking, WhiteKing_selected, WhiteKing_xy, h1c);
            move(pictureBox_whitebishop2, WhiteBishop2_selected, WhiteBishop2_xy, h1c);
            move(pictureBox_whiteknight2, WhiteKnight2_selected, WhiteKnight2_xy, h1c);
            move(pictureBox_whiterook2, WhiteRook2_selected, WhiteRook2_xy, h1c);
        }

        private void pictureBox_h2_Click(object sender, EventArgs e)

        {
            move(pictureBox_blackpawn1, BlackPawn1_selected, BlackPawn1_xy, h2c);
            move(pictureBox_blackpawn2, BlackPawn2_selected, BlackPawn2_xy, h2c);
            move(pictureBox_blackpawn3, BlackPawn3_selected, BlackPawn3_xy, h2c);
            move(pictureBox_blackpawn4, BlackPawn4_selected, BlackPawn4_xy, h2c);
            move(pictureBox_blackpawn5, BlackPawn5_selected, BlackPawn5_xy, h2c);
            move(pictureBox_blackpawn6, BlackPawn6_selected, BlackPawn6_xy, h2c);
            move(pictureBox_blackpawn7, BlackPawn7_selected, BlackPawn7_xy, h2c);
            move(pictureBox_blackpawn8, BlackPawn8_selected, BlackPawn8_xy, h2c);
            move(pictureBox_blackrook1, BlackRook1_selected, BlackRook1_xy, h2c);
            move(pictureBox_blackknight1, BlackKnight1_selected, BlackKnight1_xy, h2c);
            move(pictureBox_blackbishop1, BlackBishop1_selected, BlackBishop1_xy, h2c);
            move(pictureBox_blackqueen, BlackQueen_selected, BlackQueen_xy, h2c);
            move(pictureBox_blackking, BlackKing_selected, BlackKing_xy, h2c);
            move(pictureBox_blackbishop2, BlackBishop2_selected, BlackBishop2_xy, h2c);
            move(pictureBox_blackknight2, BlackKnight2_selected, BlackKnight2_xy, h2c);
            move(pictureBox_blackrook2, BlackRook2_selected, BlackRook2_xy, h2c);

            move(pictureBox_whitepawn1, WhitePawn1_selected, WhitePawn1_xy, h2c);
            move(pictureBox_whitepawn2, WhitePawn2_selected, WhitePawn2_xy, h2c);
            move(pictureBox_whitepawn3, WhitePawn3_selected, WhitePawn3_xy, h2c);
            move(pictureBox_whitepawn4, WhitePawn4_selected, WhitePawn4_xy, h2c);
            move(pictureBox_whitepawn5, WhitePawn5_selected, WhitePawn5_xy, h2c);
            move(pictureBox_whitepawn6, WhitePawn6_selected, WhitePawn6_xy, h2c);
            move(pictureBox_whitepawn7, WhitePawn7_selected, WhitePawn7_xy, h2c);
            move(pictureBox_whitepawn8, WhitePawn8_selected, WhitePawn8_xy, h2c);
            move(pictureBox_whiterook1, WhiteRook1_selected, WhiteRook1_xy, h2c);
            move(pictureBox_whiteknight1, WhiteKnight1_selected, WhiteKnight1_xy, h2c);
            move(pictureBox_whitebishop1, WhiteBishop1_selected, WhiteBishop1_xy, h2c);
            move(pictureBox_whitequeen, WhiteQueen_selected, WhiteQueen_xy, h2c);
            move(pictureBox_whiteking, WhiteKing_selected, WhiteKing_xy, h2c);
            move(pictureBox_whitebishop2, WhiteBishop2_selected, WhiteBishop2_xy, h2c);
            move(pictureBox_whiteknight2, WhiteKnight2_selected, WhiteKnight2_xy, h2c);
            move(pictureBox_whiterook2, WhiteRook2_selected, WhiteRook2_xy, h2c);
        }

        private void pictureBox_h3_Click(object sender, EventArgs e)

        {
            move(pictureBox_blackpawn1, BlackPawn1_selected, BlackPawn1_xy, h3c);
            move(pictureBox_blackpawn2, BlackPawn2_selected, BlackPawn2_xy, h3c);
            move(pictureBox_blackpawn3, BlackPawn3_selected, BlackPawn3_xy, h3c);
            move(pictureBox_blackpawn4, BlackPawn4_selected, BlackPawn4_xy, h3c);
            move(pictureBox_blackpawn5, BlackPawn5_selected, BlackPawn5_xy, h3c);
            move(pictureBox_blackpawn6, BlackPawn6_selected, BlackPawn6_xy, h3c);
            move(pictureBox_blackpawn7, BlackPawn7_selected, BlackPawn7_xy, h3c);
            move(pictureBox_blackpawn8, BlackPawn8_selected, BlackPawn8_xy, h3c);
            move(pictureBox_blackrook1, BlackRook1_selected, BlackRook1_xy, h3c);
            move(pictureBox_blackknight1, BlackKnight1_selected, BlackKnight1_xy, h3c);
            move(pictureBox_blackbishop1, BlackBishop1_selected, BlackBishop1_xy, h3c);
            move(pictureBox_blackqueen, BlackQueen_selected, BlackQueen_xy, h3c);
            move(pictureBox_blackking, BlackKing_selected, BlackKing_xy, h3c);
            move(pictureBox_blackbishop2, BlackBishop2_selected, BlackBishop2_xy, h3c);
            move(pictureBox_blackknight2, BlackKnight2_selected, BlackKnight2_xy, h3c);
            move(pictureBox_blackrook2, BlackRook2_selected, BlackRook2_xy, h3c);

            move(pictureBox_whitepawn1, WhitePawn1_selected, WhitePawn1_xy, h3c);
            move(pictureBox_whitepawn2, WhitePawn2_selected, WhitePawn2_xy, h3c);
            move(pictureBox_whitepawn3, WhitePawn3_selected, WhitePawn3_xy, h3c);
            move(pictureBox_whitepawn4, WhitePawn4_selected, WhitePawn4_xy, h3c);
            move(pictureBox_whitepawn5, WhitePawn5_selected, WhitePawn5_xy, h3c);
            move(pictureBox_whitepawn6, WhitePawn6_selected, WhitePawn6_xy, h3c);
            move(pictureBox_whitepawn7, WhitePawn7_selected, WhitePawn7_xy, h3c);
            move(pictureBox_whitepawn8, WhitePawn8_selected, WhitePawn8_xy, h3c);
            move(pictureBox_whiterook1, WhiteRook1_selected, WhiteRook1_xy, h3c);
            move(pictureBox_whiteknight1, WhiteKnight1_selected, WhiteKnight1_xy, h3c);
            move(pictureBox_whitebishop1, WhiteBishop1_selected, WhiteBishop1_xy, h3c);
            move(pictureBox_whitequeen, WhiteQueen_selected, WhiteQueen_xy, h3c);
            move(pictureBox_whiteking, WhiteKing_selected, WhiteKing_xy, h3c);
            move(pictureBox_whitebishop2, WhiteBishop2_selected, WhiteBishop2_xy, h3c);
            move(pictureBox_whiteknight2, WhiteKnight2_selected, WhiteKnight2_xy, h3c);
            move(pictureBox_whiterook2, WhiteRook2_selected, WhiteRook2_xy, h3c);
        }

        private void pictureBox_h4_Click(object sender, EventArgs e)

        {
            move(pictureBox_blackpawn1, BlackPawn1_selected, BlackPawn1_xy, h4c);
            move(pictureBox_blackpawn2, BlackPawn2_selected, BlackPawn2_xy, h4c);
            move(pictureBox_blackpawn3, BlackPawn3_selected, BlackPawn3_xy, h4c);
            move(pictureBox_blackpawn4, BlackPawn4_selected, BlackPawn4_xy, h4c);
            move(pictureBox_blackpawn5, BlackPawn5_selected, BlackPawn5_xy, h4c);
            move(pictureBox_blackpawn6, BlackPawn6_selected, BlackPawn6_xy, h4c);
            move(pictureBox_blackpawn7, BlackPawn7_selected, BlackPawn7_xy, h4c);
            move(pictureBox_blackpawn8, BlackPawn8_selected, BlackPawn8_xy, h4c);
            move(pictureBox_blackrook1, BlackRook1_selected, BlackRook1_xy, h4c);
            move(pictureBox_blackknight1, BlackKnight1_selected, BlackKnight1_xy, h4c);
            move(pictureBox_blackbishop1, BlackBishop1_selected, BlackBishop1_xy, h4c);
            move(pictureBox_blackqueen, BlackQueen_selected, BlackQueen_xy, h4c);
            move(pictureBox_blackking, BlackKing_selected, BlackKing_xy, h4c);
            move(pictureBox_blackbishop2, BlackBishop2_selected, BlackBishop2_xy, h4c);
            move(pictureBox_blackknight2, BlackKnight2_selected, BlackKnight2_xy, h4c);
            move(pictureBox_blackrook2, BlackRook2_selected, BlackRook2_xy, h4c);

            move(pictureBox_whitepawn1, WhitePawn1_selected, WhitePawn1_xy, h4c);
            move(pictureBox_whitepawn2, WhitePawn2_selected, WhitePawn2_xy, h4c);
            move(pictureBox_whitepawn3, WhitePawn3_selected, WhitePawn3_xy, h4c);
            move(pictureBox_whitepawn4, WhitePawn4_selected, WhitePawn4_xy, h4c);
            move(pictureBox_whitepawn5, WhitePawn5_selected, WhitePawn5_xy, h4c);
            move(pictureBox_whitepawn6, WhitePawn6_selected, WhitePawn6_xy, h4c);
            move(pictureBox_whitepawn7, WhitePawn7_selected, WhitePawn7_xy, h4c);
            move(pictureBox_whitepawn8, WhitePawn8_selected, WhitePawn8_xy, h4c);
            move(pictureBox_whiterook1, WhiteRook1_selected, WhiteRook1_xy, h4c);
            move(pictureBox_whiteknight1, WhiteKnight1_selected, WhiteKnight1_xy, h4c);
            move(pictureBox_whitebishop1, WhiteBishop1_selected, WhiteBishop1_xy, h4c);
            move(pictureBox_whitequeen, WhiteQueen_selected, WhiteQueen_xy, h4c);
            move(pictureBox_whiteking, WhiteKing_selected, WhiteKing_xy, h4c);
            move(pictureBox_whitebishop2, WhiteBishop2_selected, WhiteBishop2_xy, h4c);
            move(pictureBox_whiteknight2, WhiteKnight2_selected, WhiteKnight2_xy, h4c);
            move(pictureBox_whiterook2, WhiteRook2_selected, WhiteRook2_xy, h4c);
        }

        private void pictureBox_h5_Click(object sender, EventArgs e)

        {
            move(pictureBox_blackpawn1, BlackPawn1_selected, BlackPawn1_xy, h5c);
            move(pictureBox_blackpawn2, BlackPawn2_selected, BlackPawn2_xy, h5c);
            move(pictureBox_blackpawn3, BlackPawn3_selected, BlackPawn3_xy, h5c);
            move(pictureBox_blackpawn4, BlackPawn4_selected, BlackPawn4_xy, h5c);
            move(pictureBox_blackpawn5, BlackPawn5_selected, BlackPawn5_xy, h5c);
            move(pictureBox_blackpawn6, BlackPawn6_selected, BlackPawn6_xy, h5c);
            move(pictureBox_blackpawn7, BlackPawn7_selected, BlackPawn7_xy, h5c);
            move(pictureBox_blackpawn8, BlackPawn8_selected, BlackPawn8_xy, h5c);
            move(pictureBox_blackrook1, BlackRook1_selected, BlackRook1_xy, h5c);
            move(pictureBox_blackknight1, BlackKnight1_selected, BlackKnight1_xy, h5c);
            move(pictureBox_blackbishop1, BlackBishop1_selected, BlackBishop1_xy, h5c);
            move(pictureBox_blackqueen, BlackQueen_selected, BlackQueen_xy, h5c);
            move(pictureBox_blackking, BlackKing_selected, BlackKing_xy, h5c);
            move(pictureBox_blackbishop2, BlackBishop2_selected, BlackBishop2_xy, h5c);
            move(pictureBox_blackknight2, BlackKnight2_selected, BlackKnight2_xy, h5c);
            move(pictureBox_blackrook2, BlackRook2_selected, BlackRook2_xy, h5c);

            move(pictureBox_whitepawn1, WhitePawn1_selected, WhitePawn1_xy, h5c);
            move(pictureBox_whitepawn2, WhitePawn2_selected, WhitePawn2_xy, h5c);
            move(pictureBox_whitepawn3, WhitePawn3_selected, WhitePawn3_xy, h5c);
            move(pictureBox_whitepawn4, WhitePawn4_selected, WhitePawn4_xy, h5c);
            move(pictureBox_whitepawn5, WhitePawn5_selected, WhitePawn5_xy, h5c);
            move(pictureBox_whitepawn6, WhitePawn6_selected, WhitePawn6_xy, h5c);
            move(pictureBox_whitepawn7, WhitePawn7_selected, WhitePawn7_xy, h5c);
            move(pictureBox_whitepawn8, WhitePawn8_selected, WhitePawn8_xy, h5c);
            move(pictureBox_whiterook1, WhiteRook1_selected, WhiteRook1_xy, h5c);
            move(pictureBox_whiteknight1, WhiteKnight1_selected, WhiteKnight1_xy, h5c);
            move(pictureBox_whitebishop1, WhiteBishop1_selected, WhiteBishop1_xy, h5c);
            move(pictureBox_whitequeen, WhiteQueen_selected, WhiteQueen_xy, h5c);
            move(pictureBox_whiteking, WhiteKing_selected, WhiteKing_xy, h5c);
            move(pictureBox_whitebishop2, WhiteBishop2_selected, WhiteBishop2_xy, h5c);
            move(pictureBox_whiteknight2, WhiteKnight2_selected, WhiteKnight2_xy, h5c);
            move(pictureBox_whiterook2, WhiteRook2_selected, WhiteRook2_xy, h5c);
        }

        private void pictureBox_h6_Click(object sender, EventArgs e)

        {
            move(pictureBox_blackpawn1, BlackPawn1_selected, BlackPawn1_xy, h6c);
            move(pictureBox_blackpawn2, BlackPawn2_selected, BlackPawn2_xy, h6c);
            move(pictureBox_blackpawn3, BlackPawn3_selected, BlackPawn3_xy, h6c);
            move(pictureBox_blackpawn4, BlackPawn4_selected, BlackPawn4_xy, h6c);
            move(pictureBox_blackpawn5, BlackPawn5_selected, BlackPawn5_xy, h6c);
            move(pictureBox_blackpawn6, BlackPawn6_selected, BlackPawn6_xy, h6c);
            move(pictureBox_blackpawn7, BlackPawn7_selected, BlackPawn7_xy, h6c);
            move(pictureBox_blackpawn8, BlackPawn8_selected, BlackPawn8_xy, h6c);
            move(pictureBox_blackrook1, BlackRook1_selected, BlackRook1_xy, h6c);
            move(pictureBox_blackknight1, BlackKnight1_selected, BlackKnight1_xy, h6c);
            move(pictureBox_blackbishop1, BlackBishop1_selected, BlackBishop1_xy, h6c);
            move(pictureBox_blackqueen, BlackQueen_selected, BlackQueen_xy, h6c);
            move(pictureBox_blackking, BlackKing_selected, BlackKing_xy, h6c);
            move(pictureBox_blackbishop2, BlackBishop2_selected, BlackBishop2_xy, h6c);
            move(pictureBox_blackknight2, BlackKnight2_selected, BlackKnight2_xy, h6c);
            move(pictureBox_blackrook2, BlackRook2_selected, BlackRook2_xy, h6c);

            move(pictureBox_whitepawn1, WhitePawn1_selected, WhitePawn1_xy, h6c);
            move(pictureBox_whitepawn2, WhitePawn2_selected, WhitePawn2_xy, h6c);
            move(pictureBox_whitepawn3, WhitePawn3_selected, WhitePawn3_xy, h6c);
            move(pictureBox_whitepawn4, WhitePawn4_selected, WhitePawn4_xy, h6c);
            move(pictureBox_whitepawn5, WhitePawn5_selected, WhitePawn5_xy, h6c);
            move(pictureBox_whitepawn6, WhitePawn6_selected, WhitePawn6_xy, h6c);
            move(pictureBox_whitepawn7, WhitePawn7_selected, WhitePawn7_xy, h6c);
            move(pictureBox_whitepawn8, WhitePawn8_selected, WhitePawn8_xy, h6c);
            move(pictureBox_whiterook1, WhiteRook1_selected, WhiteRook1_xy, h6c);
            move(pictureBox_whiteknight1, WhiteKnight1_selected, WhiteKnight1_xy, h6c);
            move(pictureBox_whitebishop1, WhiteBishop1_selected, WhiteBishop1_xy, h6c);
            move(pictureBox_whitequeen, WhiteQueen_selected, WhiteQueen_xy, h6c);
            move(pictureBox_whiteking, WhiteKing_selected, WhiteKing_xy, h6c);
            move(pictureBox_whitebishop2, WhiteBishop2_selected, WhiteBishop2_xy, h6c);
            move(pictureBox_whiteknight2, WhiteKnight2_selected, WhiteKnight2_xy, h6c);
            move(pictureBox_whiterook2, WhiteRook2_selected, WhiteRook2_xy, h6c);
        }

        private void pictureBox_h7_Click(object sender, EventArgs e)

        {
            move(pictureBox_blackpawn1, BlackPawn1_selected, BlackPawn1_xy, h7c);
            move(pictureBox_blackpawn2, BlackPawn2_selected, BlackPawn2_xy, h7c);
            move(pictureBox_blackpawn3, BlackPawn3_selected, BlackPawn3_xy, h7c);
            move(pictureBox_blackpawn4, BlackPawn4_selected, BlackPawn4_xy, h7c);
            move(pictureBox_blackpawn5, BlackPawn5_selected, BlackPawn5_xy, h7c);
            move(pictureBox_blackpawn6, BlackPawn6_selected, BlackPawn6_xy, h7c);
            move(pictureBox_blackpawn7, BlackPawn7_selected, BlackPawn7_xy, h7c);
            move(pictureBox_blackpawn8, BlackPawn8_selected, BlackPawn8_xy, h7c);
            move(pictureBox_blackrook1, BlackRook1_selected, BlackRook1_xy, h7c);
            move(pictureBox_blackknight1, BlackKnight1_selected, BlackKnight1_xy, h7c);
            move(pictureBox_blackbishop1, BlackBishop1_selected, BlackBishop1_xy, h7c);
            move(pictureBox_blackqueen, BlackQueen_selected, BlackQueen_xy, h7c);
            move(pictureBox_blackking, BlackKing_selected, BlackKing_xy, h7c);
            move(pictureBox_blackbishop2, BlackBishop2_selected, BlackBishop2_xy, h7c);
            move(pictureBox_blackknight2, BlackKnight2_selected, BlackKnight2_xy, h7c);
            move(pictureBox_blackrook2, BlackRook2_selected, BlackRook2_xy, h7c);

            move(pictureBox_whitepawn1, WhitePawn1_selected, WhitePawn1_xy, h7c);
            move(pictureBox_whitepawn2, WhitePawn2_selected, WhitePawn2_xy, h7c);
            move(pictureBox_whitepawn3, WhitePawn3_selected, WhitePawn3_xy, h7c);
            move(pictureBox_whitepawn4, WhitePawn4_selected, WhitePawn4_xy, h7c);
            move(pictureBox_whitepawn5, WhitePawn5_selected, WhitePawn5_xy, h7c);
            move(pictureBox_whitepawn6, WhitePawn6_selected, WhitePawn6_xy, h7c);
            move(pictureBox_whitepawn7, WhitePawn7_selected, WhitePawn7_xy, h7c);
            move(pictureBox_whitepawn8, WhitePawn8_selected, WhitePawn8_xy, h7c);
            move(pictureBox_whiterook1, WhiteRook1_selected, WhiteRook1_xy, h7c);
            move(pictureBox_whiteknight1, WhiteKnight1_selected, WhiteKnight1_xy, h7c);
            move(pictureBox_whitebishop1, WhiteBishop1_selected, WhiteBishop1_xy, h7c);
            move(pictureBox_whitequeen, WhiteQueen_selected, WhiteQueen_xy, h7c);
            move(pictureBox_whiteking, WhiteKing_selected, WhiteKing_xy, h7c);
            move(pictureBox_whitebishop2, WhiteBishop2_selected, WhiteBishop2_xy, h7c);
            move(pictureBox_whiteknight2, WhiteKnight2_selected, WhiteKnight2_xy, h7c);
            move(pictureBox_whiterook2, WhiteRook2_selected, WhiteRook2_xy, h7c);
        }

        private void pictureBox_h8_Click(object sender, EventArgs e)

        {
            move(pictureBox_blackpawn1, BlackPawn1_selected, BlackPawn1_xy, h8c);
            move(pictureBox_blackpawn2, BlackPawn2_selected, BlackPawn2_xy, h8c);
            move(pictureBox_blackpawn3, BlackPawn3_selected, BlackPawn3_xy, h8c);
            move(pictureBox_blackpawn4, BlackPawn4_selected, BlackPawn4_xy, h8c);
            move(pictureBox_blackpawn5, BlackPawn5_selected, BlackPawn5_xy, h8c);
            move(pictureBox_blackpawn6, BlackPawn6_selected, BlackPawn6_xy, h8c);
            move(pictureBox_blackpawn7, BlackPawn7_selected, BlackPawn7_xy, h8c);
            move(pictureBox_blackpawn8, BlackPawn8_selected, BlackPawn8_xy, h8c);
            move(pictureBox_blackrook1, BlackRook1_selected, BlackRook1_xy, h8c);
            move(pictureBox_blackknight1, BlackKnight1_selected, BlackKnight1_xy, h8c);
            move(pictureBox_blackbishop1, BlackBishop1_selected, BlackBishop1_xy, h8c);
            move(pictureBox_blackqueen, BlackQueen_selected, BlackQueen_xy, h8c);
            move(pictureBox_blackking, BlackKing_selected, BlackKing_xy, h8c);
            move(pictureBox_blackbishop2, BlackBishop2_selected, BlackBishop2_xy, h8c);
            move(pictureBox_blackknight2, BlackKnight2_selected, BlackKnight2_xy, h8c);
            move(pictureBox_blackrook2, BlackRook2_selected, BlackRook2_xy, h8c);

            move(pictureBox_whitepawn1, WhitePawn1_selected, WhitePawn1_xy, h8c);
            move(pictureBox_whitepawn2, WhitePawn2_selected, WhitePawn2_xy, h8c);
            move(pictureBox_whitepawn3, WhitePawn3_selected, WhitePawn3_xy, h8c);
            move(pictureBox_whitepawn4, WhitePawn4_selected, WhitePawn4_xy, h8c);
            move(pictureBox_whitepawn5, WhitePawn5_selected, WhitePawn5_xy, h8c);
            move(pictureBox_whitepawn6, WhitePawn6_selected, WhitePawn6_xy, h8c);
            move(pictureBox_whitepawn7, WhitePawn7_selected, WhitePawn7_xy, h8c);
            move(pictureBox_whitepawn8, WhitePawn8_selected, WhitePawn8_xy, h8c);
            move(pictureBox_whiterook1, WhiteRook1_selected, WhiteRook1_xy, h8c);
            move(pictureBox_whiteknight1, WhiteKnight1_selected, WhiteKnight1_xy, h8c);
            move(pictureBox_whitebishop1, WhiteBishop1_selected, WhiteBishop1_xy, h8c);
            move(pictureBox_whitequeen, WhiteQueen_selected, WhiteQueen_xy, h8c);
            move(pictureBox_whiteking, WhiteKing_selected, WhiteKing_xy, h8c);
            move(pictureBox_whitebishop2, WhiteBishop2_selected, WhiteBishop2_xy, h8c);
            move(pictureBox_whiteknight2, WhiteKnight2_selected, WhiteKnight2_xy, h8c);
            move(pictureBox_whiterook2, WhiteRook2_selected, WhiteRook2_xy, h8c);
        }
        //SQRS
        //Click actions
    }
}