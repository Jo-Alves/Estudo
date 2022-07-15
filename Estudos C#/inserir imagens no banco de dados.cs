using System.Data.SqlClient;
//metodo dopara imagem em picteribox
  MemoryStream ms = new MemoryStream();
                    pb_ImageLogo.Image.Save(ms, ImageFormat.Jpeg);
                    byte[] imagem = new byte[ms.Length];
                    ms.Position = 0;
                    ms.Read(imagem, 0, imagem.Length);
					
				SqlConnection conexao=new Sql("sdsdfsd");
					 _sql = "Insert into empresa values (@Foto)";
                SqlCommand comando = new SqlCommand(_sql, conexao);
                comando.Parameters.AddWithValue("@Foto", imagem);              
                comando.CommandText = _sql;
                try
                {
                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conexao.Close();
                }
					//converte string para byte
					        byte[] imagem = Encoding.ASCII.GetBytes(logoEmpresa);