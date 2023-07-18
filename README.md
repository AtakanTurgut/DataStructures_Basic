# Basic Data Structures with C#

## [Arrays](https://github.com/AtakanTurgut/DataStructures_Basic/blob/main/arrays/arrays/Program.cs) 
Array   |   Dizi -> Arrays are of reference type.   <br />
![](pictures/arrays.png)

## [HashTables](https://github.com/AtakanTurgut/DataStructures_Basic/blob/main/hashtables/hashtables/Program.cs) 
Hashtable   |       non-generic -> object -> boxing/unboxing    <br />
key - value pairs | ConteinKey - ContainValue           (key, value)    <br />
![](pictures/hashtables.PNG) 

## [SortedLists](https://github.com/AtakanTurgut/DataStructures_Basic/blob/main/sortedlists/sortedlists/Program.cs) 
SortedList  |       non-generic -> object   <br />
key - value pairs  |   Sort by insertion added.         (key, value)    <br />
Access can be provided by key and index.  |  IndexOfKey - IndexOfValue  ->  GetKey - GetValue   <br /> 
![](pictures/sortedlists.PNG) 

## [Lists<T<T>>](https://github.com/AtakanTurgut/DataStructures_Basic/blob/main/lists/lists/Program.cs)
List<>   |       Type Safety  -> generic     <br />
Interface -> Inheritance : Inherits contracts.  <br />
![](pictures/lists.PNG) 

## [Stacks<T<T>>](https://github.com/AtakanTurgut/DataStructures_Basic/blob/main/stacks/stacks/Program.cs) 
Stack<>  |  Yığın           Type Safety  -> generic     <br />
Last-in First-out     ->  LIFO      <br />
.push() -> Ekleme          .pop() -> Çıkarma           .ToArray() -> int[]     <br />
![](pictures/stacks.PNG) 

## [Queues<T<T>>](https://github.com/AtakanTurgut/DataStructures_Basic/blob/main/queues/queues/Program.cs) 
Queue<>  |   Kuyruk         Type Safety  -> generic    <br />
First-in First-out    ->  FIFO  <br />
.Enqueue() -> Ekleme       .Dequeue() -> Çıkarma    <br />
The Operating System is used to set operating priorities.   <br />
    -> İşletim sistemlerinde çalışma önceliğini belirlemede kullanılır.   <br />
![](pictures/queues.PNG)

## [LinkedLists<T<T>>](https://github.com/AtakanTurgut/DataStructures_Basic/blob/main/linkedlists/linkedlists/Program.cs) 
LinkedList<>  |  Bağlı Liste           Type Safety  -> generic  <br />
Non-sequential, linear data structure.  <br />

               Node   ==   - | data | pointer
               <- | previous | data | next | ->
               firstNode ... lastNode

.AddFirst()      .AddLast()      .First()    .Last()     .AddBefore()    .AddAfter()    <br />
![](pictures/linkedlists.PNG)