using BLL.DesignPattern.GenericReposityoryPattern.ContRep;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAUI
{
    public partial class form1 : Form
    {
        HataRepository error;
        NotRepository note;
        public form1()
        {
            InitializeComponent();
            error = new HataRepository();
            note = new NotRepository();
        }

        private void form1_Load(object sender, EventArgs e)
        {
            gb_rb.Visible = false;

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {

            if(rb_error.Checked)
            {
                dgw.DataSource = error.Where(x => x.TypeOf.Contains(txt_search.Text) || x.WhyFor.Contains(txt_search.Text) || x.Howfixed.Contains(txt_search.Text));  
            }
            else if(rb_note.Checked)
            {
                dgw.DataSource = note.Where(x => x.Subject.Contains(txt_search.Text) || x.Contain.Contains(txt_search.Text));
            }
            else
            {
                dgw.DataSource = error.Where(x => x.TypeOf.Contains(txt_search.Text) || x.WhyFor.Contains(txt_search.Text) || x.Howfixed.Contains(txt_search.Text));
                dgw.DataSource = note.Where(x => x.Subject.Contains(txt_search.Text) || x.Contain.Contains(txt_search.Text));
            }
            


        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if(btn_save.Text == "SAVE")
            {
                if (rb_error.Checked && txt_search != null && txt_whyfor != null)
                {
                    Hata er = new Hata();
                    er.TypeOf = txt_subject.Text;
                    er.WhyFor = txt_whyfor.Text;
                    er.Howfixed = txt_howfix.Text;
                    error.Add(er);
                }
                else if (rb_note.Checked && (rb_low.Checked || rb_medium.Checked || rb_high.Checked))
                {
                    Not nt = new Not();
                    nt.Subject = txt_subject.Text;
                    nt.Contain = txt_whyfor.Text;
                    if (rb_low.Checked)
                    {
                        nt.Level = Model.Enums.SignificanceLevel.Low;
                    }
                    else if (rb_medium.Checked)
                    {
                        nt.Level = Model.Enums.SignificanceLevel.Medium;
                    }
                    else
                    {
                        nt.Level = Model.Enums.SignificanceLevel.High;
                    }
                    note.Add(nt);
                }
                else
                {
                    MessageBox.Show("Lütfen Doğru Veri Girdiğinizden Emin Olunuz...");
                }
                txt_subject.Clear();
                txt_howfix.Clear();
                txt_whyfor.Clear();
                MessageBox.Show("Başarıyla Kaydedilmiştir");
            }
            else if(btn_save.Text == "UPDATE")
            {
                if(rb_error.Checked==true)
                {
                    int id = Convert.ToInt32(txt_subject.Tag);
                    Hata er = error.Find(id);
                    er.ModifiedDate = DateTime.Now;
                    er.TypeOf = txt_subject.Text;
                    er.WhyFor = txt_whyfor.Text;
                    er.Howfixed = txt_howfix.Text;
                    error.Update(er);

                }
                else if(rb_note.Checked == true)
                {
                    
                }
            }
            
        }

        private void rb_error_CheckedChanged(object sender, EventArgs e)
        {
            //Eğer olurda tag dolu olup'da notdan hataya geçiş yapılırsa tag boşalsınki ID'ye bağlı hatalı kayıt olmasın
            txt_subject.Tag = null;
            gb_rb.Visible = false;
            txt_howfix.Visible = true;
            lbl_howfix.Visible = true;
            lbl_whyfor.Text = "WhyFor";
            dgw.DataSource = error.GetAll();
        }

        private void rb_note_CheckedChanged(object sender, EventArgs e)
        {
            txt_subject.Tag = null;
            gb_rb.Visible = true;
            //radio buttonların durduğu textbox görünürden kalktı.
            txt_howfix.Visible = false;
            //Labelların görünümü ve ismi nota göre modifiye edildi.
            lbl_howfix.Visible = false;
            lbl_whyfor.Text = "Contains";
            dgw.DataSource = note.GetAll();
        }

        private void dgw_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (rb_error.Checked && e.RowIndex != -1)
            {

                DataGridViewRow dg = dgw.Rows[e.RowIndex];
                txt_subject.Tag = dg.Cells[3].Value;
                txt_subject.Text = dg.Cells[0].Value.ToString();
                txt_whyfor.Text = dg.Cells[1].Value.ToString();
                txt_howfix.Text = dg.Cells[2].Value.ToString();

            }
            else if (rb_note.Checked && e.RowIndex != -1)
            {
                DataGridViewRow dg = dgw.Rows[e.RowIndex];
                txt_subject.Tag = dg.Cells[3].Value;
                txt_subject.Text = dg.Cells[0].Value.ToString();
                txt_whyfor.Text = dg.Cells[1].Value.ToString();
                if(dg.Cells[2].Value.ToString() == "Low")
                {
                    rb_low.Checked = true;
                }
                else if(dg.Cells[2].Value.ToString() == "Medium")
                {
                    rb_medium.Checked = true;
                }
                else if(dg.Cells[2].Value.ToString() == "High")
                {
                    rb_high.Checked = true;
                }
            }
            btn_save.Text = "UPDATE";

        }
        private void Clear()
        {
            txt_subject.Tag = null;
            txt_subject.Clear();
            txt_whyfor.Clear();
            txt_howfix.Clear();
        }

        private void form1_Click(object sender, EventArgs e)
        {
            Clear();
            btn_save.Text = "Save";
        }

        private void dgw_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }














        //Bir kotrol methodu yazılabilir...
        //Radiobuttonlar basılı olmayınca veya herhangi biri baısı olunca yapılacakları yaz.
    }
}
