using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Windows.Forms;

namespace Login
{
    class NovoRelatorio
    {
        DataTable dt = new DataTable();
        Paragrafos novoparagrafo = new Paragrafos();
        InnerClass join = new InnerClass();

        HashSet<string> lista = new HashSet<string>();
        HashSet<string> fontes = new HashSet<string>();
        HashSet<string> pragas = new HashSet<string>();
        HashSet<string> doencas = new HashSet<string>();


        public string caminho;

        public HashSet<string> ConverVegetableToString(DataTable table)
        {
            HashSet<string> vegetable = new HashSet<string>();
            string semeadura;
            string tratos;
            string fonte;
            string praga;
            string doenca;
            string transpante;

            for (int i = 0; i < table.Rows.Count; i++)
            {

                string nome = (string)table.Rows[i]["Nome"];
                string epoca = (string)table.Rows[i]["epoca"];
                string propagacao = (string)table.Rows[i]["propagacao"];
                bool tipoSemeadura = (bool)table.Rows[i]["semeadura"];

                vegetable.Add(nome);
                vegetable.Add(epoca);
                vegetable.Add(propagacao);

                //Tratando semeadura caso seja nula
                if (tipoSemeadura == true)
                {
                    semeadura = "SIM";
                    vegetable.Add(semeadura);

                }
                else
                {
                    semeadura = "NAO";
                    vegetable.Add(semeadura);

                }


                //Tratando casos em que trasplante é nulo
                if (table.Rows[i]["transplante"] == DBNull.Value)
                {
                    transpante = "--";
                    vegetable.Add(transpante);
                }
                else
                {
                    transpante = (string)table.Rows[i]["transplante"];
                    vegetable.Add(transpante);
                }

                string espacamento = (string)table.Rows[i]["espacamento"];
                string colheita = (string)table.Rows[i]["colheita"];
                string produtividade = (string)table.Rows[i]["produtividade"];
                string irrigacao = (string)table.Rows[i]["irrigacao"];

                vegetable.Add(espacamento);
                vegetable.Add(colheita);
                vegetable.Add(produtividade);
                vegetable.Add(irrigacao);


                //Tratando casos em que tratos culturais é nulo
                if (table.Rows[i]["tratos_culturais"] == DBNull.Value)
                {
                    tratos = "--";
                }
                else
                {
                    tratos = (string)table.Rows[i]["tratos_culturais"];
                }


                //Validadndo as fontes caso ela seja nula
                if (table.Rows[i]["fonte"] == DBNull.Value)
                {
                    fonte = "--";
                    fontes.Add(fonte);

                }
                else
                {
                    fonte = (string)table.Rows[i]["fonte"];
                    fontes.Add(fonte);
                }

                //Validadndo pragas caso ela seja nula
                if (table.Rows[i]["pragas"] == DBNull.Value)
                {
                    praga = "--";
                    pragas.Add(praga);

                }
                else
                {
                    praga = (string)table.Rows[i]["pragas"];
                    pragas.Add(praga);
                }


                //Validadndo doenças caso ela seja nula
                if (table.Rows[i]["doencas"] == DBNull.Value)
                {
                    doenca = "--";
                    doencas.Add(doenca);

                }
                else
                {
                    doenca = (string)table.Rows[i]["doencas"];
                    doencas.Add(doenca);
                }


                vegetable.Add(tratos);
            }

            return vegetable;
        }

        public void gerarRelatorio(string nome, string tableName)
        {

            if (tableName == "HORTALICAS")
            {
                dt = join.vegetablesInformation(nome);

                lista = ConverVegetableToString(dt);
            }
            else
            {
                join.vegetablesInformation(nome);
            }

            //Usando classe Document para iniciar criação do pdf com modelo A4
            Document doc = new Document(PageSize.A4);
            try
            {

                // Definindo margins
                doc.SetMargins(40, 40, 40, 80);
                doc.AddCreationDate();
                //Caminho e nome do arquvo
                caminho = @"C:\Users\bruno\Downloads\" + nome +".pdf";

                //Aqui se estancia o arquivo que se deseja gerar
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(caminho, FileMode.Create));

                //Abrindo arquivo
                doc.Open();

                //Adicionando imagem no arquivo
                string logo = @"C:\Users\bruno\Desktop\ProjetoLP2-BackyardGarden\Imagems\folhahortanoquintal.png";
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
                for (int i = 0; i < lista.Count; i++)
                {
                    string aux = lista.ElementAt(i);

                    primeiraTabela.AddCell(aux);
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

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                doc.Close();
            }

        }
    }
}
