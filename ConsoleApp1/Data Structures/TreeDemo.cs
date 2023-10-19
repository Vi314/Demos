using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demonstrations.Data_Structures {
    public class TreeDemo : IDemonstration {
        public void Run() {
            var tree = new Tree(1);
            tree.Append(2, 1);
            tree.Append(3, 2);
            tree.Append(4, 2);
            tree.Append(5, 4);
            tree.Append(6, 4);
            tree.Append(7, 3);

            tree.Print();
            Console.WriteLine(tree.ToTreeString());
        }

        class Tree(int rootKey) {
            List<Node> nodes = new List<Node> { new Node(rootKey) };

            public int Append(int key, int parent = 0) {
                //Parent must exist, node with same key must not
                if(!nodes.Where(x => x.Key == parent).Any()
                   || nodes.Where(x => x.Key == key).Any()) {
                    return -1;
                }
                nodes.Add(new Node(key, parent));
                return 0;
            }

            public void Print() {
                foreach(var node in nodes) {
                    Console.Write($"--[K:{node.Key}-P:{node.Parent}]--");
                }
                Console.WriteLine();
            }
            public string ToTreeString() {
                string tree = $"1-) _[{nodes[0].Key}]_\n";
                for(int i = 1; i < nodes.Count; i++) {
                    string message = $"{i+1}-)";
                    var nodesString = nodes.Where(x => x.Parent == nodes[i - 1].Key)?.ToList();
                    if(nodesString?.Count is 0 or null) {
                        break;
                    }
                    nodesString.ForEach(x => { message += $"_[{x.Key}:{x.Parent}]"; });
                    message += "_\n";
                    tree += message;
                }
                return tree;
            }

            struct Node(int keyVal, int parentKey = 0) {
                public int Key    = keyVal;
                public int Parent = parentKey;
            }
        }


    }
}
