using System;
using System.Collections.Generic;
using System.Data;
using Npgsql;
using NpgsqlTypes;

namespace Login
{
    class Paragrafos
    {


    public string primeiroParagrafo()
    {
        string texto = "O texto e tabelas apresentados a seguir tratam das opções anotadas +  
        "pelo usuário para o plantio em áreas sob sua responsabilidade. De forma " +  
        "alguma, pretende-se esgotar o assunto, devido a complexidade do tema " +
        "mas apenas fornecer as orientações gerais para facilitar os tratos " +
        "culturais e reduzir substancialmente os riscos inerentes a qualquer " + 
        "exploração agrícola, principalmente devido às variações climáticas e " + 
        "ocorrências inesperadas, como pragas e/ou doenças.Nesse sentido, " +
        "fornecemos, na forma de uma tabela, as principais características e " +
        "exigências específicas das espécies escolhidas.";

        return texto;
    }

    public string segundoParagrafo()
    {
        string texto = "Esta tabela deve buscar as opções dos usuários e copiar as " +
        "informações das tabelas criadas. Atenção especial deve ser dada às colunas " +
        "Semeadura Direta e Transplante época. A data de plantio deve ser informada "+
        "pelo usuário e a coluna Previsão de Colheita será calculada pelos dados das "
        "tabelas básicas criadas. Pode ser extendida até o final das suas opções, lembrando "+
        "apenas de separar Hortaliças de Frutas, pois as colunas são diferentes..";

        return texto;
    }

    public string terceiroParagrafo()
    {
        return "A tabela a seguir servirá de orientação caso ocorram pragas e/ou doenças "+
        "nas suas culturas, onde as pragas/doenças estão relacionadas com os produtos  indicados " +
        "e a sua formulação (para preparo caseiro), bem como as dosagens e forma de aplicação. "
        "Lembrar que apesar de não serem defensivos agrícolas comerciais, os agrotóxicos, "+
        "também podem causar problemas caso a manipulação não seja cercada de cuidados como o uso "+
        "de EPI (equipamentos de proteção individual), como luvas, botas e máscaras. "+
        "Alguns desses produtos podem ser encontrados já formulados e podem ser adquiridos em lojas "+
        "especializadas de produtos agropecuários. O uso depende da ocorrência, não devendo ser "+
        "aplicados preventivamente (as exceções estão comentadas). Procurar aplicar sempre nas horas "+
        "mais frescas do dia, logo pela manhã ou no final da tarde/inicio da noite, visando minimizar os potenciais danos.";
    }

    public string quartoParagrafo()
    {
        return "Esta tabela deverá receber os dados relativos à coluna Pragas/Doenças das culturas escolhidas";
    }

    public string quintoParagrafo()
    {
        return = "Nesta tabela relacionamos os fertilizantes naturais indicados para todas as culturas com as respectivas dosagens. As dosagens foram fornecidas em volume para facilitar o manuseio, 
        "já que fica mais difícil pesar e isso é condicionado pelo teor de umidade destes produtos. "+ 
        "Algumas recomendações importantes:\n"+
        "1. Sempre aplicar os fertilizantes de plantio cerca de 15 a 20 dias antes do plantio, "+ 
        "misturando-os à terra, numa profundidade de cerca de 10 cm, irrigando diariamente para "+
        "terminar a “cura” dos mesmos. Após esse período, as mudas ou sementes poderão ser plantadas.\n"
    
        "2. Quando da aplicação em cobertura, depositar a cerca de 5 cm dos pés dos vegetais, "+
        "se possível, passando um rastelo ou cultivador de forma bem superficial e irrigar em seguida.\n" 
        
        "3. Os fertilizantes e as respectivas dosagens indicadas dizem respeito ao total que a planta "+ 
        "deve receber, entretanto, caso haja vontade ou disponibilidade de associar mais de um "+
        "fertilizante, as dosagens devem ser relativizadas, sob o risco de queimar ou matar as plantas.\n"

        "4. Quando do uso desses fertilizantes em covas de frutíferas, as dosagens referem-se à "+
        "aplicação em covas de dimensões de 60 x 60 x 60 cm, devendo receber os mesmos cerca de "+
        "15 a 20 dias antes do plantio.\n"

        "5. Existem muitas outras opções de fertilizantes naturais, entretanto é condição de "+
        "especificidades regionais ou disponíveis em apenas algumas épocas do ano, por isso não "+
        "foram relacionadas.";
    }

    public string sextoParagrafo()
    {
        return "Transcrever a tabela de fertilizantes na totalidade, retirando as colunas relativas aos nutrientes. Em todas as recomendações.";
    }

    public string segundoTitulo()
    {
        return = "Recomendamos a leitura cuidadosa dessas recomendações iniciais, visando o máximo aproveitamento com um mínimo de riscos.";
    }

    public string setimoParagrafo()
    {
        return = "1. Para se obter o máximo de rendimento da(s) espécie(s) escolhidas para plantio, "+
        "observar a(s) recomendação(ões) da(s) época(s) sugeridas. Eventualmente pode-se plantar em "+
        "outras épocas, implicando isso no aumento considerável de riscos de eventos climáticos, "+
        "pragas e doenças que normalmente não ocorreriam e consequente perdas na produção.\n"
        "2. As áreas mínimas recomendadas, ou seja, a partir de 10m2  para as hortaliças e a "+
        "partir de 100 m2 para frutíferas levam em conta um mix de espécies, considerando as áreas "+
        "ocupadas pelas plantas na fase adulta, o que não impede que se plantem, por exemplo, poucos "+
        "exemplares, o que implica em perda do propósito inicial do projeto, de oferecer variedade com "+
        "qualidade o ano todo.\n"
        "3. O uso de defensivos agrícolas é condicionado ao aparecimento de pragas e/ou doenças, e em "+
        "alguns casos específicos, apolicados preventivamente quando assim explicitamente recomendado "+
        "no planejamento (tabelas).\n"
        "4. Semeadura direta significa o plantio de sementes diretamente no canteiro, enquanto "+
        "Transplante significa o plantio inicialmente em vasos ou copinhos ou cartelas de ovos ou "+
        "sementeiras ou copos de jornal, para a partir de determinada fase (em número de folhas já "+
        "estabelecidas) serem transplantadas no canteiro definitivo. O Transplante pressupõe o "+
        "desbaste, ou seja, a eliminação do excesso de mudas (deve ficar apenas uma ou no máximo "+
        "duas por recipiente), bem como a escolha das mais fortes e viçosas.\n"
        "5. A produção esperada, bem como o cálculo da época de colheita, varia em função da época de "+
        "plantio, tipo de solo e boas práticas aplicadas (como tratamento de pragas/doenças, ervas "+
        "daninhas, adubação, irrigação), ou seja, pode sofrer variações, servindo apenas de referência na tabela.\n"
        "6. Torta de Mamona e Torta de Algodão são extremamente tóxicas para animais domésticos, devendo "+
        "ser evitadas quando da presença destes.\n"
        "7. Todos os fertilizantes indicados referem-se a produtos devidamente curtidos para a "+
        "aplicação. Produtos frescos podem causar queimaduras ou morte das plantas, principalmente "+
        "nas fases iniciais.\n"
        "8. As frutíferas podem ser plantadas o ano todo, evitando-se épocas mais sujeitas a geadas, "+
        "desde que devidamente irrigadas conforme as orientações e sempre que possível, protegendo a "+
        "superfície da cova com cobertura morta (exemplo, capim).\n"
        "9. A irrigação, sempre que possível, deve-se evitar o impacto direto de jatos na terra, "+
        "o que pode causar erosão e selamento superficial. Para tanto, procurar adaptar na ponta da "+
        "mangueira um “chuveirinho” e reduzir a pressão para melhorar a eficiência e o aproveitamento da água.";
    }

    

    }
}
