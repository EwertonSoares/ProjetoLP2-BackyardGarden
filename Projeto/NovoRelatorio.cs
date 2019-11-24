using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Windows.Forms;

namespace Login
{
    class NovoRelatorio
    {
        Paragrafos novoparagrafo = new Paragrafos();
        public string caminho;

        public void gerarRelatorio(string nome)
        {
            try
            {
                //Usando classe Document para iniciar criação do pdf com modelo A4
                Document doc = new Document(PageSize.A4);
                // Definindo margins
                doc.SetMargins(40, 40, 40, 80);
                doc.AddCreationDate();
                //Caminho e nome do arquvo
                caminho = @"C:\Users\EWERTON\Downloads\" + nome +".pdf";

                //Aqui se estancia o arquivo que se deseja gerar
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(caminho, FileMode.Create));

                //Abrindo arquivo
                doc.Open();

                //Adicionando imagem no arquivo
                string logo = "https://cdn.pixabay.com/photo/2015/11/26/20/29/sol-1064482_960_720.png";
                Image img = Image.GetInstance(logo);
                img.ScaleAbsolute(100, 120);
                doc.Add(img);

                //Crindo paragrafos para o arquivo
                Paragraph titulo = new Paragraph();
                titulo.Font = new Font(Font.FontFamily.HELVETICA, 15);
                titulo.Alignment = Element.ALIGN_CENTER;
                titulo.Add("PLANEJAMENTO GERAL – GUIA DE ORIENTAÇÕES PRÁTICAS\n\n");
                doc.Add(titulo);

                Paragraph primeiroParagrafo = new Paragraph("", new Font(Font.NORMAL, 10));
                string primeiroConteudo = novoparagrafo.primeiroParagrafo();
                primeiroParagrafo.Add(primeiroConteudo);
                doc.Add(primeiroParagrafo);

                //Criando tabela para o arquivo
                PdfPTable primeiraTabela = new PdfPTable(new float[] { 530f, 550f, 550f, 600f, 600f,
                550f, 550f, 800f, 700f, 600f, 550f, 800f });

                Font nf = FontFactory.GetFont(BaseFont.TIMES_BOLD, 5);

                Paragraph p1 = new Paragraph("ESPÉCIE (NOME COMUM)", nf);
                Paragraph p2 = new Paragraph("EPOCA PARA O PLANTIO", nf);
                Paragraph p3 = new Paragraph("FORMA DE PROPAGAÇÃO", nf);
                Paragraph p4 = new Paragraph("SEMEADURA DIRETA", nf);
                Paragraph p5 = new Paragraph("EPOCA PARA TRANSPLANTE", nf);
                Paragraph p6 = new Paragraph("ESPAÇAMENTO PARA O PLANTIO", nf);
                Paragraph p7 = new Paragraph("PREVISÃO PARA A COLHEITA", nf);
                Paragraph p8 = new Paragraph("PRODUTIVIDADE ESPERADA", nf);
                Paragraph p9 = new Paragraph("IRRIGAÇÃO", nf);
                Paragraph p10 = new Paragraph("PRAGAS MAIS COMUNS", nf);
                Paragraph p11 = new Paragraph("DOENÇAS MAIS COMUNS", nf);
                Paragraph p12 = new Paragraph("TRATOS CULTURAIS\n ESPECIFICOS", nf);


                //Linha 1 até a coluna 12
                primeiraTabela.AddCell(p1);
                primeiraTabela.AddCell(p2);
                primeiraTabela.AddCell(p3);
                primeiraTabela.AddCell(p4);
                primeiraTabela.AddCell(p5);
                primeiraTabela.AddCell(p6);
                primeiraTabela.AddCell(p7);
                primeiraTabela.AddCell(p8);
                primeiraTabela.AddCell(p9);
                primeiraTabela.AddCell(p10);
                primeiraTabela.AddCell(p11);
                primeiraTabela.AddCell(p12);

                //Linha 2 até a coluna 12
                for (int i = 1; i <= 12; i++)
                {
                    primeiraTabela.AddCell(i.ToString());
                    primeiraTabela.AddCell(i.ToString());
                    primeiraTabela.AddCell(i.ToString());
                    primeiraTabela.AddCell(i.ToString());
                    primeiraTabela.AddCell(i.ToString());
                    primeiraTabela.AddCell(i.ToString());
                    primeiraTabela.AddCell(i.ToString());
                    primeiraTabela.AddCell(i.ToString());
                    primeiraTabela.AddCell(i.ToString());
                    primeiraTabela.AddCell(i.ToString());
                    primeiraTabela.AddCell(i.ToString());
                }
                doc.Add(primeiraTabela);

                //Criando Segundo Paragrafo
                Paragraph segundoParagrafo = new Paragraph("", new Font(Font.NORMAL, 12));
                string segundoConteudo = novoparagrafo.segundoParagrafo();
                segundoParagrafo.Add(segundoConteudo);
                doc.Add(segundoParagrafo);

                //Criando terceiro paragrafo
                Paragraph terceiroParagrafo = new Paragraph("", new Font(Font.NORMAL, 12));
                string terceiroConteudo = novoparagrafo.terceiroParagrafo();
                terceiroParagrafo.Add(terceiroConteudo);
                doc.Add(terceiroParagrafo);

                //Criando segunda tabela
                PdfPTable segundaTabela = new PdfPTable(5);

               //Linha 1 até a coluna 5
                segundaTabela.AddCell("PRAGAS");
                segundaTabela.AddCell("DOENÇAS");
                segundaTabela.AddCell("PRODUTO INDICADO");
                segundaTabela.AddCell("FORMULAÇÃO");
                segundaTabela.AddCell("DOSAGEM E APLICAÇÃO");

                //Linha 2 até a coluna 12
                for (int i = 1; i <= 5; i++)
                {
                    segundaTabela.AddCell("--");
                    segundaTabela.AddCell("--");
                    segundaTabela.AddCell("--");
                    segundaTabela.AddCell("--");
                    segundaTabela.AddCell("--");
                }
                doc.Add(segundaTabela);

                //Adicionando quarto paragrafo
                Paragraph quartoParagrafo = new Paragraph("", new Font(Font.NORMAL, 12));
                string qurtoConteudo = novoparagrafo.quartoParagrafo();
                quartoParagrafo.Add(qurtoConteudo);
                doc.Add(quartoParagrafo);

                //Adicionando quinto paragrafo
                Paragraph quintoParagrafo = new Paragraph("", new Font(Font.NORMAL, 12));
                string quintoConteudo = novoparagrafo.quintoParagrafo();
                quintoParagrafo.Add(quintoConteudo);
                doc.Add(quintoParagrafo);

                //Criando terceira tabela
                PdfPTable terceiraTabela = new PdfPTable(4);

                //Linha 1 até a coluna 5
                terceiraTabela.AddCell("FERTILIZANTES");
                terceiraTabela.AddCell("PLANTIO");
                terceiraTabela.AddCell("COBERTURA");
                terceiraTabela.AddCell("OBSERVAÇÕES");

                //Linha 2 até a coluna 3
                for (int i = 1; i <= 4; i++)
                {
                    terceiraTabela.AddCell("--");
                    terceiraTabela.AddCell("--");
                    terceiraTabela.AddCell("--");
                    terceiraTabela.AddCell("--");

                }
                doc.Add(terceiraTabela);

                //Adicionando sexto paragrafo
                Paragraph sextoParagrafo = new Paragraph("", new Font(Font.NORMAL, 12));
                string sextoConteudo = novoparagrafo.sextoParagrafo();
                sextoParagrafo.Add(sextoConteudo);
                doc.Add(sextoParagrafo);

                //Adicionando segundo titulo/Paragrago
                Paragraph segunTit = new Paragraph("", new Font(Font.NORMAL, 12));
                string segundotitulo = novoparagrafo.segundoTitulo();
                segunTit.Add(segundotitulo);
                doc.Add(segunTit);

                //Adicionando setimo paragrago
                Paragraph setimoParagrafo = new Paragraph("", new Font(Font.NORMAL, 12));
                string setimoConteudo = novoparagrafo.setimoParagrafo();
                setimoParagrafo.Add(setimoConteudo);
                doc.Add(setimoParagrafo);

                doc.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
