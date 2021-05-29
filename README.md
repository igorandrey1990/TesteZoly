Exercício de Programação
Zoly - Martech
2021
1 Introdução
Uma empresa empregou N desenvolvedores (numerados de 0 a N − 1) e quer dividí-los em duas
equipes.

1. A primeira é uma equipe de front-end com F desenvolvedores.
2. A segunda é uma equipe de back-end com N-F desenvolvedores.

Se o K-ésimo desenvolvedor é atribuído à equipe de front-end, então sua contribuição é A[K], se ele é atribuído à equipe de back-end, então sua contribuição é B[K].

2 Exercício

Qual é a soma máxima de contribuições que a empresa pode obter?
Escreva uma função:

function solution(A, B, F); que, dado dois arrays A, B (consistindo de N inteiros cada) e o inteiro F, retorna a soma máxima de contribuições que a empresa pode alcançar.

Exemplos:

1. Dado A = [4, 2, 1], B = [2, 5, 3] e F = 2, a função deve retornar 10. Deve haver dois
desenvolvedores front-end e um desenvolvedor back-end. O 0º e o 2º desenvolvedores devem
ser atribuídos à equipe de front-end (com as contribuições 4 e 1) e o 1º desenvolvedor deve
ser atribuído à equipe de back-end (com contribuição 5).

2. Dado A = [7, 1, 4, 4], B = [5, 3, 4, 3] e F = 2, a função deve retornar 18. O 0º e 3º
desenvolvedores devem ser atribuídos à equipe de front-end e os 1º e 2º desenvolvedores
devem ser atribuídos à equipe de back-end.

3. Dado A = [5, 5, 5], B = [5, 5, 5] e F = 1, a função deve retornar 15. O 0º desenvolvedor
pode ser atribuído à equipe de front-end e o 1º e o 2º desenvolvedores podem ser atribuídos
à equipe de back-end.

3 Premissas

Escreva um algoritmo eficiente para as seguintes suposições:

1. N é um inteiro dentro do intervalo 1...200000
2. arrays A e B têm comprimentos iguais entre si e igual a N;
3. cada elemento dos arrays A e B é um inteiro dentro do intervalo [0...1000];
4. F é um inteiro dentro do intervalo [0...N].
