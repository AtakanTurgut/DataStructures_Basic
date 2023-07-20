# Basic Data Structures with C#

## [- Limit of Data Types -](https://github.com/AtakanTurgut/DataStructures_Basic/blob/main/LimitofDataTypes/LimitofDataTypes/Program.cs) 
object -> reference type    <br />
class -> It is used to define the user-side data type. <br />
<br />
8-bit -> 1 byte   <br />
![](pictures/LimitofDataTypes.PNG)

## [Arrays](https://github.com/AtakanTurgut/DataStructures_Basic/blob/main/arrays/arrays/Program.cs) 
Array   |   Dizi -> Arrays are of reference type.   <br />
- It has a method that cleans up array parts.    <br />
- Allows array definition by specifying the type.    <br />
- It is a class that contains array functions.   <br />
![](pictures/arrays.png)

## [HashTables()](https://github.com/AtakanTurgut/DataStructures_Basic/blob/main/hashtables/hashtables/Program.cs) 
Hashtable   |       non-generic -> object -> boxing/unboxing    <br />
- key - value pairs | ConteinKey - ContainValue           (key, value)    <br />
![](pictures/hashtables.PNG) 

## [SortedLists()](https://github.com/AtakanTurgut/DataStructures_Basic/blob/main/sortedlists/sortedlists/Program.cs) 
SortedList  |       non-generic -> object   <br />
- key - value pairs  |   Sort by insertion added.  |   Sorts ascending.       (key, value)    <br />
- Access can be provided by key and index.  |  IndexOfKey - IndexOfValue  ->  GetKey - GetValue   <br /> 
![](pictures/sortedlists.PNG) 

## [Lists<-T->](https://github.com/AtakanTurgut/DataStructures_Basic/blob/main/lists/lists/Program.cs)
List<-T->   |       Type Safety  -> generic     <br />
- Interface -> Inheritance : Inherits contracts.  <br />
![](pictures/lists.PNG) 

## [Stacks<-T->](https://github.com/AtakanTurgut/DataStructures_Basic/blob/main/stacks/stacks/Program.cs) 
Stack<-T->  |  Yığın           Type Safety  -> generic     <br />
- Last-in First-out     ->  LIFO      <br />
- .push() -> Ekleme          .pop() -> Çıkarma        .Clear() -> Yığını boşaltma        .ToArray() -> int[]     <br />
![](pictures/stacks.PNG) 

## [Queues<-T->](https://github.com/AtakanTurgut/DataStructures_Basic/blob/main/queues/queues/Program.cs) 
Queue<-T->  |   Kuyruk         Type Safety  -> generic    <br />
- First-in First-out    ->  FIFO  <br />
- .Enqueue() -> Ekleme       .Dequeue() -> Çıkarma    <br />
- The Operating System is used to set operating priorities.   <br />
- -> İşletim sistemlerinde çalışma önceliğini belirlemede kullanılır.   <br />
![](pictures/queues.PNG)

## [LinkedLists<-T->](https://github.com/AtakanTurgut/DataStructures_Basic/blob/main/linkedlists/linkedlists/Program.cs) 
LinkedList<-T->  |  Bağlı Liste           Type Safety  -> generic  <br />
- Non-sequential, linear data structure.  <br />
- .AddFirst()      .AddLast()      .First()    .Last()     .AddBefore()    .AddAfter()    <br />

            Node   ==   - | data | pointer
            <- | previous | data | next | ->
            firstNode ... lastNode
            
![](pictures/linkedlists.PNG)

## [Dictionaries<-TKey, TValue->](https://github.com/AtakanTurgut/DataStructures_Basic/blob/main/dictionaries/dictionaries/Program.cs) 
Dictionary<-TKey,  TValue->    |         Type Safety  -> generic      <br />
- TKey -> It must be unique.   |    TValue -> The value you want.       <br />
![](pictures/dictionaries.PNG)

## [SortedDictionaries<-TKey, TValue->](https://github.com/AtakanTurgut/DataStructures_Basic/blob/main/sorteddictionaries/sorteddictionaries/Program.cs) 
SortedDictionary<-TKey,  TValue->    |        Type Safety  -> generic      <br />
- TKey -> It must be unique.   |    TValue -> The value you want.       <br />
- Sorting is done by the expression 'TKey'.       <br />
![](pictures/sorteddictionaries.PNG)

## [SortedSets<-T->](https://github.com/AtakanTurgut/DataStructures_Basic/blob/main/sortedsets/sortedsets/Program.cs) 
SortedSet<-T->    |   Type Safety -> generic  |  dynamic      <br />
- Elements must be different from each other.     <br />
- intersect,  union,  except,  subset     <br />
- -> kesişim, birleşim, ayrışım, alt küme    <br />
            
         A = { 1, 2, 3, 4 }          B = { 1, 2, 5, 6 }
             A.UnionWith(B) -> { 1, 2, 3, 4, 5, 6 }
             A.IntersectWith(B) -> { 1, 2 }
             A.ExceptWith(B) -> { 3, 4 }
             B.ExceptWith(A) -> { 5, 6 }
             A.SymmetricExceptWith(B) -> { 3, 4, 5, 6 }
            
![](pictures/sortedsets.PNG)

## [HashSets<-T->](https://github.com/AtakanTurgut/DataStructures_Basic/blob/main/hashsets/hashsets/Program.cs) 
HashSet<-T->    |    Type Safety -> generic      <br />
- Elements must be different from each other, but non-sorted.     <br />
- intersect,  union,  except,  subset     <br />
- -> kesişim, birleşim, ayrışım, alt küme    <br />
            
         A = { 1, 2, 3, 4 }          B = { 1, 2, 5, 6 }
             A.UnionWith(B) -> { 1, 2, 3, 4, 5, 6 }
             A.IntersectWith(B) -> { 1, 2 }
             A.ExceptWith(B) -> { 3, 4 }
             B.ExceptWith(A) -> { 5, 6 }
             A.SymmetricExceptWith(B) -> { 3, 4, 5, 6 }
            
![](pictures/hashsets.PNG)