﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServerTest.Database;

namespace ServerTest.Server.ServerInterface
{

    public class FormsManaging
    {
        public static int size;
        public static TextBox TextGenerator(string Message)
        {

            TextBox text = new TextBox();
            text.Text = $"{DateTime.Now.ToString()} ---> {Message}";
            text.Size = text.GetPreferredSize(text.Size);
            text.Anchor = AnchorStyles.Left;
            System.Drawing.Size size = new System.Drawing.Size();
            size.Height = 500;
            size.Width = 1050;
            //text.Size = size;
            text.ReadOnly = true;
            text.BorderStyle = BorderStyle.None;
            TextToList(text);
            return text;

        }
        public static void TextToList(TextBox text) => UI.MessangerPanel.Controls.Add(text);
    }
}
