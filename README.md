# MestreDosCodigos.Escudeiro
Projeto de implementação do nível "Escudeiro" do "Mestre dos Códigos"

Perguntas teóricas:

1. Em quais linguagens o C# foi inspirado?
R: Apesar de ter sido bastante criticado a princípio por ser simplesmente um clone de Java, o criador da ferramenta diz ter se inspirado principalmente em C++ para desenvolver o C#, apesar das semelhanças com Java serem inegaveis.
  
2. Inicialmente o C# foi criado para qual finalidade?
R: Para ser uma linguagem orientada a objeto, simples, moderna, para uso geral, que garantisse robustez, durabilidade e produtividade no desenvolvimento de software.

3. Quais os principais motivos para a Microsoft ter migrado para o Core?
R: Simplificação das bibliotecas de classe que já compunham o .Net Framework, construção de aplicações multiplataforma e transformar em uma ferramenta Open Source.

4. Cite as principais diferenças entre .Net Full Framework e .Net Core.
R: O .Net Core permite o desenvolvimento multiplataformas enquanto o .Net Framework possui uma biblioteca de ferramentas muito mais extensa (embora com o passar dos anos, o .Net Core tem ficado cada vez mais rico em suas ferramentas). Outro ponto é que o .Net Core foi reescrito com base no .Net Framework, então muitos dos problemas detectados nele fora corrigidos no Core.

---------------------------------------------------------------
POO

1. O que é POO?
R: POO (Programação Orientada a Objeto) é um paradigma de linguegens de programação que usa o conceito de objetos como sendo entidades isoladas contendo código para definição de atributos específicos para cada tipo de objeto, e métodos específicos para a manipulação desses atributos.

2. O que é polimorfismo?
R: É a habilidade de duas classes que herdam a mesma classe pai, poderem ter implementações do mesmo método herdade com comportamentos diferentes. 
Outra característica do polimorfismo é a utilização de interfaces. Se ambas as classes "Animal" e "Pessoa" implementam a interface "IMovel", ambas podem ser passadas como parâmetro para um método de assinatura: Movimentar(IMovel objetoMovel). 

3. O que é abstração?
R: Abstração é o conceito de identificar um objeto apenas com as características que são relevantes para o contexto. Ex: Um aluno de nome "Fulano de Tal" possui o RA: "123456" e data de nascimento "01/01/2001". Nesse contexto adicionar a informação "Conta bancária" não é relavante para identificar esse objeto Aluno, então feriria a abstração de dados.

4. O que é encapsulamento?
R: Encapsulamento é o conceito de "ocultar" certos dados, ou facilitar a forma de obter algum dado de um objeto. Ex: Se o aluno possui um vetor de notas, eu posso ocultar o acesso a essas notas mas prover um método de acesso "CalcularMedia" que já faria o serviço de cálculo internamente.

5. Quando usar uma classe abstrata e quando devo usar uma interface?
Uma interface é um modelo a ser seguido, ela não implementa nenhum comportamento sozinha, mas força o desenvolvedor a implementar um comportamento para todos os métodos que ela possui. Uma classes abstrata pode definir atributos padrão, ter implementações genéricas de métodos e permitir a reescrita desses comportamentos para implementações especializadas.

6. O que faz as interfaces IDisposable, IComparable, ICloneable e IEnumerable?
R: 
  IDisposable: Implementa o método Dispose(), que permite a desalocação de recursos não gerenciados automaticamente. Ex: ponteiros para DLLs externas.
  IComparable: Implementa o método CompareTo(), que permite a utilização de métodos de ordenação e comparação em objetos complexos, e não somente em atributos simples.
  ICloneable: Implementa o método Clone(), que cria uma cópia do objeto em memória, e não uma cópia do endereço em memória. O método também permite uma implementação explícita de como o objeto será copiado (cópia de objetos aninhados, zerar IDs, etc)
  IEnumerable: Implementa GetEnumerator(), que permite que o objeto possa ser percorrido com foreach, por exemplo. Ao implementar um classe com IEnumerable, também deve ser implementado uma classe com IEnumerator, que vai ser cada objeto da coleção que implementa IEnumerable.
  
7. Existe herança múltipla (de classes) em C#?
R: Não, uma classe só pode ter uma classe em sua herança, mas pode implementar diversas interfaces.
