  OpenFileDialog AbrirAquirvo = new OpenFileDialog();
            AbrirAquirvo.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*";
            if (AbrirAquirvo.ShowDialog() == DialogResult.OK)
            {
                //string nome = AbrirAquirvo.FileName;
                //btm = new Bitmap(nome);
                //pictureBox1.Image = btm;
                foreach (string arquivo in AbrirAquirvo.FileNames)
                {
                    Image Imagem = Image.FromFile(arquivo);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                      //pb.Height = loadedImage.Height;
                        //pb.Width = loadedImage.Width;
                       pictureBox1.Height = 100;
                        pictureBox1.Width = 100;
                        //atribui a imagem ao PictureBox - pb
                       pictureBox1.Image = Imagem;
                        //inclui a imagem no containter flowLayoutPanel
                        flowLayoutPanel1.Controls.Add(pictureBox1);
                }
            }