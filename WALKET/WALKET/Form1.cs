using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WALKET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckBox[] check_vip = {checkBox46, checkBox45, checkBox44, checkBox43,
                checkBox42, checkBox41, checkBox40 };
            CheckBox[] check_orta = {checkBox1, checkBox2, checkBox3, checkBox4,
                checkBox5, checkBox6, checkBox7, checkBox8,
                checkBox9, checkBox10, checkBox11, checkBox12,
                checkBox13, checkBox14, checkBox15, checkBox16,
                checkBox17, checkBox18, checkBox19, checkBox20,
                checkBox21, checkBox22, checkBox23, checkBox24,
                checkBox25, checkBox26, checkBox27, checkBox28,
                checkBox29, checkBox30, checkBox31, checkBox32,
                checkBox33, checkBox34, checkBox35, checkBox36,
                checkBox37, checkBox38, checkBox39, checkBox47,
                checkBox48, checkBox49, checkBox50, checkBox51 };
            CheckBox[] check_sol  = {checkBox52, checkBox53, checkBox54, checkBox55,
                checkBox56, checkBox57, checkBox58, checkBox59,
                checkBox60, checkBox61, checkBox62, checkBox63,
                checkBox64, checkBox65, checkBox66, checkBox67,
                checkBox68, checkBox69, checkBox70, checkBox71,
                checkBox72, checkBox73, checkBox74, checkBox75,
                checkBox76, checkBox77, checkBox78 };
            CheckBox[] check_on   = {checkBox79, checkBox80, checkBox81, checkBox82,
                checkBox83, checkBox84, checkBox85, checkBox86,
                checkBox87, checkBox88, checkBox89, checkBox90,
                checkBox91, checkBox92, checkBox93, checkBox94,
                checkBox95, checkBox96, checkBox97, checkBox98,
                checkBox99, checkBox100, checkBox101, checkBox102,
                checkBox103, checkBox104, checkBox105 };
            int orta = 5000, sol = 3000, on = 3000, vip = 10000,
                sanvip = 0, sansol = 0,
                sanon = 0, sanorta = 0, koplate = 0 ;
            for (int i = 0; i < check_vip.Length; i++)
            {
                if (check_vip[i].Checked == true) { sanvip = sanvip + 1;}
            }
            for (int i = 0; i < check_orta.Length; i++)
            {
                if (check_orta[i].Checked == true) { sanorta = sanorta + 1;}
            }
            for (int i = 0; i < check_sol.Length; i++)
            {
                if (check_sol[i].Checked == true) { sansol = sansol + 1;}
            }
            for (int i = 0; i < check_on.Length; i++)
            {
                if (check_on[i].Checked == true) { sanon = sanon + 1;}
            }
            koplate = sanvip * vip + sanorta * orta + sansol * sol + sanon * on;
            label2.Text = Convert.ToString(koplate);
        
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CheckBox[] check_vip = {checkBox46, checkBox45, checkBox44, checkBox43,
                checkBox42, checkBox41, checkBox40 };
            CheckBox[] check_orta = {checkBox1, checkBox2, checkBox3, checkBox4,
                checkBox5, checkBox6, checkBox7, checkBox8,
                checkBox9, checkBox10, checkBox11, checkBox12,
                checkBox13, checkBox14, checkBox15, checkBox16,
                checkBox17, checkBox18, checkBox19, checkBox20,
                checkBox21, checkBox22, checkBox23, checkBox24,
                checkBox25, checkBox26, checkBox27, checkBox28,
                checkBox29, checkBox30, checkBox31, checkBox32,
                checkBox33, checkBox34, checkBox35, checkBox36,
                checkBox37, checkBox38, checkBox39, checkBox47,
                checkBox48, checkBox49, checkBox50, checkBox51 };
            CheckBox[] check_sol = {checkBox52, checkBox53, checkBox54, checkBox55,
                checkBox56, checkBox57, checkBox58, checkBox59,
                checkBox60, checkBox61, checkBox62, checkBox63,
                checkBox64, checkBox65, checkBox66, checkBox67,
                checkBox68, checkBox69, checkBox70, checkBox71,
                checkBox72, checkBox73, checkBox74, checkBox75,
                checkBox76, checkBox77, checkBox78 };
            CheckBox[] check_on = {checkBox79, checkBox80, checkBox81, checkBox82,
                checkBox83, checkBox84, checkBox85, checkBox86,
                checkBox87, checkBox88, checkBox89, checkBox90,
                checkBox91, checkBox92, checkBox93, checkBox94,
                checkBox95, checkBox96, checkBox97, checkBox98,
                checkBox99, checkBox100, checkBox101, checkBox102,
                checkBox103, checkBox104, checkBox105 };
            int 
                sorta = 51, ssol = 27, son = 27, svip = 7,
                sanvip = 0, sansol = 0,
                sanon = 0, sanorta = 0;
            for (int i = 0; i < check_vip.Length; i++)
            {
                if (check_vip[i].Checked == true) { sanvip = sanvip + 1; check_vip[i].BackColor = Color.Red; }
            }
            for (int i = 0; i < check_orta.Length; i++)
            {
                if (check_orta[i].Checked == true) { sanorta = sanorta + 1; check_orta[i].BackColor = Color.Red; }
            }
            for (int i = 0; i < check_sol.Length; i++)
            {
                if (check_sol[i].Checked == true) { sansol = sansol + 1; check_sol[i].BackColor = Color.Red; }
            }
            for (int i = 0; i < check_on.Length; i++)
            {
                if (check_on[i].Checked == true) { sanon = sanon + 1; check_on[i].BackColor = Color.Red; }
            }
            sorta = sorta - sanorta;
            son = son - sanon;
            ssol = ssol - sansol;
            svip = svip - sanvip;
            int koplate = 0;
            label2.Text = Convert.ToString(koplate);
            label5.Text = Convert.ToString(svip);
            label3.Text = Convert.ToString(sorta);
            label7.Text = Convert.ToString(ssol);
            label9.Text = Convert.ToString(son);
            
        }
    }
}
