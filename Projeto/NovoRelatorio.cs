using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Login
{
    class NovoRelatorio
    {
        Paragrafos novoparagrafo = new Paragrafos();

        public void gerarRelatorio()
        {
            //Usando classe Document para iniciar criação do pdf com modelo A4
            Document doc = new Document(PageSize.A4);
           // Definindo margins
            doc.setMargins(40, 40, 40, 80); 
            doc.AddCreationDate(); 
            //Caminho e nome do arquvo
            strring caminho = @"c:\Downloads\" + "relatorio.pdf"
            
            //Aqui se estancia o arquivo que se deseja gerar
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(caminho, FileMode.Create));
            
            //Abrindo arquivo
            doc.Open();

            //Adicionando imagem no arquivo
            string logo = "o caminho onde esta a imagem";
            Image img = Image.GetInstance(logo);
            img.ScaleAbsolute(100, 150);
            doc.Add(img);

            //Crindo paragrafos para o arquivo
            Paragraph titulo = new Paragraph();
            titulo.Fonte = new Font(Fonte.FontFamily.COURIER, 40);
            titulo.Alignment = Element.ALIGN_CENTER;
            titulo.Add("PLANEJAMENTO GERAL – GUIA DE ORIENTAÇÕES PRÁTICAS\n\n");
            doc.Add(titulo);

            Paragraph primeiroParagrafo = new Paragraph("", new Font(Font.NORMAL, 12));
            strring primeiroConteudo = novoparagrafo.primeiroParagrafo();
            primeiroParagrafo.Add(primeiroConteudo);
            doc.Add(primeiroParagrafo);

            //Criando tabela para o arquivo
            PdfTable primeiraTabela = new PdfTable(12);

            //Linha 1 até a coluna 12
            primeiraTabela.AddCell("ESPÉCIE\n (NOME COMUM)");
            primeiraTabela.AddCell("EPOCA PARA\n O PLANTIO");
            primeiraTabela.AddCell("FORMA DE\n PROPAGAÇÃO");
            primeiraTabela.AddCell("SEMEADURA\n DIRETA");
            primeiraTabela.AddCell("EPOCA PARA\n TRANSPLANTE");
            primeiraTabela.AddCell("ESPAÇAMENTO\n PARA O\n PLANTIO");
            primeiraTabela.AddCell("PREVISÃO\n PARA A\n COLHEITA");
            primeiraTabela.AddCell("PRODUTIVIDADE\n ESPERADA");
            primeiraTabela.AddCell("IRRIGAÇÃO");
            primeiraTabela.AddCell("PRAGAS MAIS\n COMUNS");
            primeiraTabela.AddCell("DOENÇAS MAIS\n COMUNS");
            primeiraTabela.AddCell("TRATOS CULTURAIS\n ESPECIFICOS");
            
            //Linha 2 até a coluna 12
            for(i = 1; i <= 12; i++)
            {
                tabela.AddCell("--");    
            }
            doc.Add(primeiraTabela);

            //Criando Segundo Paragrafo
            Paragraph segundoParagrafo = new Paragraph("", new Font(Font.NORMAL, 12));
            strring segundoConteudo = novoparagrafo.segundoParagrafo();
            segundoParagrafo.Add(segundoConteudo);
            doc.Add(segundoParagrafo);

            //Criando terceiro paragrafo
            Paragraph terceiroParagrafo = new Paragraph("", new Font(Font.NORMAL, 12));
            strring terceiroConteudo = novoparagrafo.terceiroParagrafo();
            terceiroParagrafo.Add(terceiroConteudo);
            doc.Add(terceiroParagrafo);

            //Criando segunda tabela
            PdfTable segundaTabela = new PdfTable(12);

            //Linha 1 até a coluna 5
            segundaTabela.AddCell("PRAGAS");
            segundaTabela.AddCell("DOENÇAS");
            segundaTabela.AddCell("PRODUTO INDICADO");
            segundaTabela.AddCell("FORMULAÇÃO");
            segundaTabela.AddCell("FORMULAÇÃO");
            segundaTabela.AddCell("DOSAGEM E APLICAÇÃO");

                        //Linha 2 até a coluna 12
            for(i = 1; i <= 5; i++)
            {
                tabela.AddCell(segundaTabela);    
            }
            doc.Add(segundaTabela);

            //Adicionando quarto paragrafo
            Paragraph quartoParagrafo = new Paragraph("", new Font(Font.NORMAL, 12));
            strring qurtoConteudo = novoparagrafo.quartoParagrafo();
            quartoParagrafo.Add(qurtoConteudo);
            doc.Add(quartoParagrafo);

            //Adicionando quinto paragrafo
            Paragraph quintoParagrafo = new Paragraph("", new Font(Font.NORMAL, 12));
            strring quintoConteudo = novoparagrafo.quintoParagrafo();
            quintoParagrafo.Add(quintoConteudo);
            doc.Add(quintoParagrafo);

            //Criando terceira tabela
            PdfTable terceiraTabela = new PdfTable(12);

            //Linha 1 até a coluna 5
            terceiraTabela.AddCell("FERTILIZANTES");
            terceiraTabela.AddCell("PLANTIO");
            terceiraTabela.AddCell("COBERTURA");
            terceiraTabela.AddCell("OBSERVAÇÕES");

            //Linha 2 até a coluna 3
            for(i = 1; i <= 3; i++)
            {
                tabela.AddCell(terceiraTabela);    
            }
            doc.Add(terceiraTabela);

            //Adicionando sexto paragrafo
            Paragraph sextoParagrafo = new Paragraph("", new Font(Font.NORMAL, 12));
            strring sextoConteudo = novoparagrafo.sextoParagrafo();
            sextoParagrafo.Add(sextoConteudo);
            doc.Add(sextoParagrafo);

            //Adicionando segundo titulo/Paragrago
            Paragraph segundoTitulo = new Paragraph("", new Font(Font.NORMAL, 12));
            strring segundotitulo = novoparagrafo.segundoTitulo();
            sextoParagrafo.Add(segundotitulo);
            doc.Add(segundoTitulo);

            //Adicionando setimo paragrago
            Paragraph setimoParagrafo = new Paragraph("", new Font(Font.NORMAL, 12));
            strring setimoConteudo = novoparagrafo.setimoParagrafo();
            sextoParagrafo.Add(setimoConteudo);
            doc.Add(setimoParagrafo);

            doc.close();
            System.Diagnostics.Process.Start(caminho);
        }
    }
}
