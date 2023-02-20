
**Este programa tem foco em um setor de produção de uma indústria e ele pede o seguinte:**

* O salário de cada funcionário junto ao seu nome;
* Total de funcionários de cada classe;
* Qual classe tem mais funcionários e quantos funcionário ela tem

**Para fazer a primeira parte, criei um vetor chamado `salario` para armazenar o respectivo salário de cada classe, por exemplo: 
250 representa o salário da primeira classe.  
Neste exato momento você deve estar pensando que se 250 corresponde ao salário da classe 1, porque ele está armazenado no índice 0 do vetor?  
É por isso que vem a lógica do `salario[ClasseDoFuncionario - 1]`, que serve para pegar o salário correto quando o usuário dar como entrada a sua classe**

**A segunda parte eu utilizei um lógica parecida com a anterior, o `TotalFuncionariosEmCadaClasse[ClasseDoFuncionario - 1]++` vai ser usado na saída para mostrar cada classe com sua respectiva quantidade de funcionários. Exemplo:**  
**Dei como entrada a classe 1 -> TotalFuncionariosEmCadaClasse[1 - 1]++ que pode ser descrito também como TotalFuncionariosEmCadaClasse[0]++ que vai adicionar o valor 1 no índice 0, pois incrementou.**  


