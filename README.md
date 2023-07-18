# Basic Data Structures with C#

## [Arrays](https://github.com/AtakanTurgut/DataStructures_Basic/blob/main/arrays/arrays/Program.cs) 
Array   |   Dizi -> Arrays are of reference type.
![](pictures/arrays.png)

## [HashTables](https://github.com/AtakanTurgut/DataStructures_Basic/blob/main/hashtables/hashtables/Program.cs) 
Hashtable   |       non-generic -> object -> boxing/unboxing    <br />
key - value pairs | ConteinKey - ContainValue           (key, value)
![](pictures/hashtables.PNG) 

## [SortedLists](https://github.com/AtakanTurgut/DataStructures_Basic/blob/main/sortedlists/sortedlists/Program.cs) 
SortedList  |       non-generic -> object   <br />
key - value pairs  |   Sort by insertion added.         (key, value)    <br />
Access can be provided by key and index.  |  IndexOfKey - IndexOfValue  ->  GetKey - GetValue
![](pictures/sortedlists.PNG) 

## [Lists<T<T>>](https://github.com/AtakanTurgut/DataStructures_Basic/blob/main/lists/lists/Program.cs)
List<>   |       Type Safety  -> generic     <br />
Interface -> Inheritance : Inherits contracts. 
![](pictures/lists.PNG) 

## [Stacks<T<T>>](https://github.com/AtakanTurgut/DataStructures_Basic/blob/main/stacks/stacks/Program.cs) 
Stack<>  |  Yığın           Type Safety  -> generic     <br />
Last-in First-out     ->  LIFO      <br />
.push() -> Ekleme          .pop() -> Çıkarma           .ToArray() -> int[]     
![](pictures/stacks.PNG) 

## [Queues<T<T>>](https://github.com/AtakanTurgut/DataStructures_Basic/blob/main/queues/queues/Program.cs) 
Queue<>  |   Kuyruk         Type Safety  -> generic    <br />
First-in First-out    ->  FIFO  <br />
.Enqueue() -> Ekleme       .Dequeue() -> Çıkarma    <br />
The Operating System is used to set operating priorities. -> İşletim sistemlerinde çalışma önceliğini belirlemede kullanılır.   
![](pictures/queues.PNG)

## [LinkedLists<T<T>>](https://github.com/AtakanTurgut/DataStructures_Basic/blob/main/linkedlists/linkedlists/Program.cs) 
LinkedList<>  |  Bağlı Liste           Type Safety  -> generic  <br />
Non-sequential, linear data structure.  <br />

               Node   ==   - | data | pointer
               <- | previous | data | next | ->
               firstNode ... lastNode

.AddFirst()      .AddLast()      .First()    .Last()     .AddBefore()    .AddAfter()
![](pictures/linkedlists.PNG)