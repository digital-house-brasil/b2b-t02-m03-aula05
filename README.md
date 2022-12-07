![](./digital-house-header.png)

# Laço de decisão

### Cometa Harley

> Segundo dados da revista Abril, em uma reportagem de 2009, o Halley é um famoso cometa que “visita a Terra” a cada, aproximadamente, 76 anos, quando atinge o ponto mais próximo do Sol. Sua última aparição foi em 1986.

> Você foi contratado por um observatório de astronomia para desenvolver um programa que, ao receber um ano de entrada, retorne se neste ano o cometa irá ou não passar.

> A entrada do problema será sempre composta por uma variável:

- ano: variável numérica e inteira. Esse é o ano a ser analisado pelo seu programa, que começa no nascimento de Cristo (ano zero no calendário cristão).

> Você deverá imprimir na tela:

- VAI PASSAR: caso o cometa passe no ano analisado;
- NAO VAI PASSAR: caso o cometa não passe no ano analisado.

> Entrada: 
````cmd
2062
````

> Saída
````cmd
VAI PASSAR
````
_________________________________________

### DH Schools

> Com o intuito de fazer uma correção de provas de questões abertas mais justa, a Cubos Academy School, escola da Cubos destinada a ensino de programação em escolas, utiliza um sistema de correção diferente. Nesse tipo de correção, vários professores corrigem a mesma prova e dão uma nota. Depois disso, verifica-se:

- Se a diferença entre a maior nota dada e a menor nota for maior que 2 pontos, é necessário uma recorreção da prova, pois indica que não houve consenso entre os corretores;
- Caso contrário, a nota do aluno será a média das notas dadas pelos corretores.
> A média é calculada por: $$ media  = somaDasNotas / quantidadeDeNotas $$

> Você, como consultor de programação, foi contratado para automatizar esse processo criando um programa. Deve ser digitado as 4 notas do tipo double, calcular a média e da o resultado abaixo:

- Reprovado: para média < 5
- Recuperação: para média entre 5 e 6.9
- Aprovado: para média igual ou superior a 7

> Entrada: 
````cmd
10 9 8 7
````

> Saída: 
````cmd
Aprovado
````

________________________________
### Programando animações

> Para quem está iniciando na programação de jogos, uma parte desafiadora é a implementação da lógica da mudança de animação de um personagem. Você, como funcionário da Ubsoft, uma das maiores empresas de desenvolvimentos de jogos do mundo, deve implementar a função que fará a troca de animação do Mário, na nova franquia de jogos que será lançada. A lógica é a seguinte:

- PARADO: se o player estiver no chão e com velocidade zero;
- ANDANDO: se tiver no chão e com velocidade de máximo 30;
- CORRENDO: se estiver no chão e com velocidade maior que 30;
- PULANDO: não estiver no chão;
- ATACANDO: se eles estiver atacando. Essa animação sobrepõem às demais.
- Input Format

> A entrada do seu programa será composta por três variáveis:

- velocidade: do tipo number. Mostra a velocidade do player;
- atacando: do tipo booleano. Indica se o player está ou não atacando;
- pulando: do tipo booleano. Indica se o player está ou não pulando.

> Output Format
> O algoritmo deve imprimir:
- PARADO: se o player estiver no chão e com velocidade zero;
- ANDANDO: se tiver no chão e com velocidade de máximo 30;
- CORRENDO: se estiver no chão e com velocidade maior que 30;
- PULANDO: não estiver no chão;
- ATACANDO: se eles estiver atacando. Essa animação sobrepõem às demais.

> Sample Input 0
```cmd
30
true
false
```
> Sample Output 0
```cmd
PULANDO
```


Apesar do player pussuir uma velocidade, ele está pulando.

Sample Input 1

20
true
true
Sample Output 1

ATACANDO