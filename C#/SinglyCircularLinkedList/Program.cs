using TFLCollections;

LinkedList list = new LinkedList();
list.AddNodeFirst(102);
list.AddNodeFirst(98);
list.AddNodeFirst(86);
list.AddNodeFirst(10);
list.AddNodeFirst(5);
list.AddNodeEnd(36);
 list.AddNodeAnyWhere(78);
list.Update(102,100);

list.Delete(5);
list.Display();