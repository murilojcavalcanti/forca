/*
 
    Realize a implementação do Jogo da Forca em C#.

    O jogo da forca é um jogo em que o jogador tem que acertar qual é a palavra proposta, tendo como dica o número de letras e o 
    tema ligado à palavra. A cada letra errada, é desenhada uma parte do corpo do enforcado. O jogo termina ou com o acerto da 
    palavra ou com o término do preenchimento das partes corpóreas do enforcado.

    Durante a execução do programa, o jogador deve escrever uma letra na linha de comando, caso a letra exista na palavra-chave o 
    jogo deve imprimir a letra digitada na posição correspondente, caso não exista, o jogo deve imprimir em tela a mensagem "A 
    letra digitada não existe na palavra-chave", e exibir o total de erros. A classe que encapsula a lógica do jogo deve conter 
    métodos para verificar se a letra existe na palavra-chave, se o jogador completou a palavra-chave e se a quantidade máxima de 
    tentativas foi atingida. Nota: Pode-se imprimir em tela o desenho do corpo do enforcado conforme a evolução do jogo ou apenas 
    informar a quantidade de tentativas restantes.
 */
using jogoDaForca.Logica;
using jogoDaForca.MenuForca;

MenuForca.Apresenta();

