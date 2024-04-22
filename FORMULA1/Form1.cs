using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formula1
{
    public partial class Form1 : Form
    {
        bool my_car_running = false;  // degiskenleri tanımladık
        int my_car_hız = 0;
        bool my_car_dur = true;
        bool my_car_sol = false;
        bool my_car_sag=false;
        bool my_car_fren=false;

        bool[] Rival_Cars_Left = {false,false,false};
        bool[] Rival_Cars_Right = {false,false,false};                      // 3 araba için sağ ve sol gitmeyi tanımladık
        PictureBox[] Rival_Cars_Pictureboxes = new PictureBox[3];
        Image[] Rival_Cars_Images = new Image[] { Properties.Resources.formula_yellow,
                                                 Properties.Resources.formula_green,
                                                 Properties.Resources.formula_black};
        Random rnd =new Random();

        public Form1()
        {
            InitializeComponent();
            CreateRivals(); 
        }

        public void CreateRivals()
        {
            for(int i = 0;i<3;i++) 
            {
                var rivalcar=new PictureBox();
                Rival_Cars_Pictureboxes[i]=rivalcar;       //picture box dizisinden i.arabayı rivalcar a atadık
                rivalcar.Name = "Rival_Car" + (i + 1).ToString() + "_pictureBox1";

                rivalcar.Size = new Size(52, 60);                  //gelen arabının sizeını yerini ayarlıyoruz
                rivalcar.BackColor = Color.Black;
                rivalcar.Location = new Point(124,(-500*i)-60);
                rivalcar.BackgroundImage = Rival_Cars_Images[i];
                rivalcar.BackgroundImageLayout = ImageLayout.Stretch;
                rivalcar.Visible = true;
                Main_panel1.Controls.Add(Rival_Cars_Pictureboxes[i]);   // panele ekliyoruz
                Timer Rival_Cars_Movement_Timer= new Timer();
                Rival_Cars_Movement_Timer.Tag = "Rival_Car_Timer" + i;
                Rival_Cars_Movement_Timer.Interval = 100;
                Rival_Cars_Movement_Timer.Tick += new EventHandler(Rival_Cars_Movement_Timer_Tick);
                Rival_Cars_Movement_Timer.Start();
            }
        }
        public void Rival_Cars_Movement_Timer_Tick(object sender ,EventArgs e)
        {
            Timer tm=(Timer)sender;
            int othercar =Convert.ToInt32(tm.Tag.ToString().Substring(15));
            // 0-non 1-left 2-right
            int othercar_rnd_movement=rnd.Next(0,3);
            if(othercar_rnd_movement == 0)
            {
                Rival_Cars_Right[othercar] = false;
                Rival_Cars_Left[othercar] = false;
            }
            else if (othercar_rnd_movement == 1)
            {
                Rival_Cars_Right[othercar] = false;
                Rival_Cars_Left[othercar] = true;
            }
            else if (othercar_rnd_movement == 2)
            {
                Rival_Cars_Left[othercar] = false;
                Rival_Cars_Right[othercar] = true;
            }
            if (Rival_Cars_Left[othercar] && Rival_Cars_Pictureboxes[othercar].Left>30)
            {
                Rival_Cars_Pictureboxes[othercar].Left = Rival_Cars_Pictureboxes[othercar].Left - 5;
            }
            if (Rival_Cars_Right[othercar] && Rival_Cars_Pictureboxes[othercar].Left<218)
            {
                Rival_Cars_Pictureboxes[othercar].Left = Rival_Cars_Pictureboxes[othercar].Left + 5;
            }

            Rival_Cars_Pictureboxes[othercar].Top = Rival_Cars_Pictureboxes[othercar].Top - 50+my_car_hız;

            if(Rival_Cars_Pictureboxes[othercar].Bounds.IntersectsWith(ptr_box_mycar.Bounds))
            {
                my_car_hız = 0;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)  // tuşlara basıldığında
        {
            if(e.KeyCode==Keys.Up)
            {
                my_car_fren = false;        //yukarı ok tuşuna basınca arabayı frenden çıkar ve çalıştır
                my_car_running = true ;
            }
            if (e.KeyCode == Keys.Down)
            {
                my_car_running = false;    //aşağı oka basınca  freni aktif et çalıştımayı durdur
                my_car_fren = true;
                
            }
            if (e.KeyCode == Keys.Left)
            {
                my_car_sag = false;        //sol ok tuşuna basınca sol tarafı aktif et
                my_car_sol = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                my_car_sol = false;        //sağ ok tuşuna basınca sağ tarafı aktif et
                my_car_sag = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)  //  tuşlar bırakıldığında
        {

            if (e.KeyCode == Keys.Up)
            {
                my_car_running = false;   //yukarı ok tuşunu bırakınca çalışmayı durdur
            }
            if (e.KeyCode == Keys.Down)
            { 
                my_car_fren = false;      //aşağı ok tuşunu bırakınca freni bırak
            }
            if (e.KeyCode == Keys.Left)
            {           
                my_car_sol = false;       //sol tuşu bırakınca sola gitmeyi bırak
            }
            if (e.KeyCode == Keys.Right)
            {     
                my_car_sag = false;       //sağ gitmeyi bırak
            }
        }

        private void mycarhız_timer1_Tick(object sender, EventArgs e)
        {
            if(my_car_running&& my_car_hız<80)
            {                           
                my_car_hız = my_car_hız + 5;         //araba çalışıyorsa ve araba hızı 80 den küçükse 80 e kadar +5 hızlandır
            }
            if (!my_car_running && my_car_hız > 0)
            {
                my_car_hız = my_car_hız -5;          //araba çalışmıyorsa ve hız 0 dan büyük olduğu sürece hızı -5 azalt
            }
            if (my_car_fren && my_car_hız >0)
            {
                my_car_hız = my_car_hız - 5;         //fren aktifse ve hız 0 dan büyükse -5 yavaşla
            }
            if(my_car_hız==0)
            {
                my_car_dur = true;   //araba hızı 0 a eşitse araba duruyor
            }
            else
            {
                my_car_dur=false;   //eşit değilse durmuyordur
            }
        }

        private void mycarhareket_timer1_Tick(object sender, EventArgs e)
        {
            if(!my_car_dur)     //araba durmuyorsa
            {
                Move_Lanes();
                if(my_car_sol && ptr_box_mycar.Left>30)
                {
                    ptr_box_mycar.Left = ptr_box_mycar.Left - 5;   //sol aktifse sola -5 git
                }
                if (my_car_sag && ptr_box_mycar.Left < 218)
                {
                    ptr_box_mycar.Left = ptr_box_mycar.Left + 5;   //sağ aktifse 218 e kadar sağa +5 git
                }
            }
            
        }
        public void Move_Lanes() 
        {
            ptr_box_lane.Top= ptr_box_lane.Top+my_car_hız; // şeriti arabının hızı kadar hızlandırıyoruz
            ptr_box_lane2.Top = ptr_box_lane2.Top + my_car_hız;  
        }

        
    }
}
