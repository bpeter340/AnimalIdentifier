using AnimalIdentifier_Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Found_bird.Checked = false;
            Found_cat.Checked = false;
            Found_dog.Checked = false;
            Grab_Path.Text = "";
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
        }

        private void Found_bird_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Grab_Path_TextChanged(object sender, EventArgs e)
        {

        }

        private void Go_Check_Click(object sender, EventArgs e)
        {
            
             Read_Image.Load(Grab_Path.Text);
             Read_Image.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void View_output_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            AnimalIdentifier_Base.TagReader find = new AnimalIdentifier_Base.TagReader();
            ImageTagger item = new ImageTagger();
            List<Tag> tags = item.GetTagsForImage(Grab_Path.Text);
            foreach (Tag tag in tags)
            {
                find.Polymorphic(find.check_Dog, tag);
                find.Polymorphic(find.check_Cat, tag);
                find.Polymorphic(find.check_Bird, tag);
            }

            Found_dog.Checked = find.check_Dog.Is_found;

            //if (find.check_Dog.Is_found == true)
            //    Found_dog.Checked = true;
            //if (find.check_Cat.Is_found == true)
            //    Found_cat.Checked = true;
            //if (find.check_Bird.Is_found == true)
            //    Found_bird.Checked = true;

            //if (Found_dog.Checked == Found_cat.Checked && Found_dog.Checked == true)
            //{
            //    if (Found_dog == Found_bird)
            //        View_output.Text = "A Bird, A cat and A dog are in this picture";
            //    else
            //        View_output.Text = "A dog and a cat are in this picture";
            //}
            //else if (Found_bird.Checked == Found_cat.Checked && Found_cat.Checked == true)
            //    View_output.Text = "A bird and a cat are in this picture";
            //else if (Found_dog.Checked == Found_bird.Checked && Found_bird.Checked == true)
            //    View_output.Text = "A bird and a dog are in this picture";
            //else if (Found_dog.Checked)
            //    View_output.Text = "A dog is in this picture";
            //else if (Found_cat.Checked)
            //    View_output.Text = "A cat is in this picture";
            //else if (Found_bird.Checked)
            //    View_output.Text = "A bird is in this picture";
            //else
            //    View_output.Text = "This picture contains no animals";
                
            

}

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
    }

