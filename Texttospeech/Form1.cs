using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace Texttospeech
{
    public partial class Form1 : Form
    {
        SpeechSynthesizer story = new SpeechSynthesizer();
        public Form1()
        {
            
            
            InitializeComponent();

            story.SpeakProgress += new EventHandler<SpeakProgressEventArgs>(speech_progress);
           
        }   

       
        private void speech_progress(object sender,SpeakProgressEventArgs e)
        {if(richTextBox2.Visible==true)
            {  richTextBox2.HideSelection = false;
            richTextBox2.Find(e.Text, e.CharacterPosition, RichTextBoxFinds.WholeWord);
            }
        else if(richTextBox1.Visible == true)
            { richTextBox1.HideSelection = false;
            richTextBox1.Find(e.Text, e.CharacterPosition, RichTextBoxFinds.WholeWord);
            }
            
         
        }
        private void button1_Click(object sender, EventArgs e)
        {if (richTextBox1.Visible == true)
            { story.SpeakAsync(richTextBox1.Text); }
        else if(richTextBox2.Visible=true)
            {
                story.SpeakAsync(richTextBox2.Text);
            }
            
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            story.Pause();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            story.SpeakAsyncCancelAll();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            story.Resume();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = "Many years ago there lived a dear little girl who was loved by every one who knew her; but her grand-mother was so very fond of her that she never felt she could think and do enough to please this dear grand-daughter, and she presented the little girl with a red silk cap, which suited her so well, that she would never wear anything else, and so was called Little Red-Cap.One day Red - Cap’s mother said to her: “Come, Red - Cap, here is a nice piece of meat, and a bottle of wine: take these to your grandmother; she is weak and ailing, and they will do her good. Be there before she gets up; go quietly and carefully.” The grandmother lived far away in the wood, a long walk from the village, and as Little Red - Cap came among the trees she met a Wolf; but she did not know what a wicked animal it was, and so she was not at all frightened. “Good morning, Little Red - Cap,” he said. “Thank you, Mr. Wolf,” said she. “Where are you going so early, Little Red - Cap ?” “To my grandmother’s,” she answered. “And what are you carrying in that basket?” “Some wine and meat,” she replied. “We baked the meat yesterday, so that grandmother, who is very weak, might have a nice strengthening meal.” “And where does your grandmother live?” asked the Wolf. “Oh, quite twenty minutes walk further in the forest. The cottage stands under three great oak trees; and close by are some nut bushes, by which you will at once know it.”";


            richTextBox1.Text = "Text messaging, or texting, is the act of composing and sending electronic messages, typically consisting of alphabetic and numeric characters, between two or more users of mobile devices, desktops/laptops, or other type of compatible computerText messages may be sent over a cellular network, or may also be sent via an Internet connection.";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;
            richTextBox2.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox2.Visible = false;
            richTextBox1.Visible = true;
        }
    }
}
