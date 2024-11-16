using System;

class DecisionTree
{
    class Node
    {
        public string Question { get; set; }
        public Node Yes { get; set; }
        public Node No { get; set; }

        public Node(string question)
        {
            Question = question;
            Yes = null;
            No = null;
        }
    }

    static Node CreateDecisionTree()
    {
        Node leaf1 = new Node("Let's bake a cake.");
        Node leaf2 = new Node("Stay hungry then.");
        Node leaf3 = new Node("Then let's make some fries.");
        Node leaf4 = new Node("Stay hungry then.");
        Node leaf5 = new Node("Ok.");

        Node node0 = new Node("Do you want tea, too?");
        node0.Yes = leaf1;
        node0.No = leaf5;

        Node node3a = new Node("Do you like cake?");
        node3a.Yes = node0;
        node3a.No = leaf2;

        Node node2 = new Node("Do you like ketchup?");
        node2.Yes = leaf3;
        node2.No = leaf5;

        Node node3b = new Node("Do you like fries?");
        node3b.Yes = node2;
        node3b.No = leaf4;

        Node node1 = new Node("Do you have a sweet tooth?");
        node1.Yes = node3a;
        node1.No = node3b;

        Node root = new Node("Do you want something to eat?");
        root.Yes = node1;
        root.No = leaf5;

        return root;
    }

    static void TraverseTree(Node node)
    {
        if (node == null)
        {
            return;
        }

        Console.WriteLine(node.Question);

        string decision = Console.ReadLine().ToLower();

        switch (decision)
        {
            case "yes":
                if (node.Yes != null)
                    TraverseTree(node.Yes);
                else
                    Console.WriteLine("No further questions.");
                break;

            case "no":
                if (node.No != null)
                    TraverseTree(node.No);
                else
                    Console.WriteLine("No further questions.");
                break;

            default:
                Console.WriteLine("Invalid input. Please answer 'yes' or 'no'.");
                TraverseTree(node); 
                break;
        }
    }

    static void Main(string[] args)
    {
        Node decisionTree = CreateDecisionTree();
        TraverseTree(decisionTree);
    }
}

