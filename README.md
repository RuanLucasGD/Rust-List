# CSharp-List
Estrutura de list duplamente encadeada em Csharp usando tipos genericos

## Uso:

* Criando nova lista

```
using CSharp_Custom_List;
	 
class Program
{
	static void Main(string[] args) {
  
  	// crie a lista para guardar o tipo de dado que quiser
		List<type> myList = new List<type>();	
	}
}
```

* Usando a lista

```
myList.Add(element);		// adiciona um elemento no final da lista
myList.Remove(element);	// remove determinado elemento já contido na lista
```

* Obtendo dados da lista

```
myList.ShowData(); // imprime todos os dados da lista
myList.Get(index); // obetenha algum elemento da lista pelo seu index
