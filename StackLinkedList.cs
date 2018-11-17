using System;

internal class Node{
	internal int data;
	internal Node next;
	public Node(int d){
		data = d;
		next=null;
	}
}

internal class LinkedList{
	Node top;
	public LinkedList(){
		this.top = null;
	}
	internal void push(int value){
		Node newNode = new Node(value);
		if(top == null)
			newNode.next = null;
		else
			newNode.next = top;
		top = newNode;
	}
	internal void pop(){
		if(top == null)
			return;
		Console.WriteLine("Pop() element {0}",top.data);
		top = top.next;
		
		
	}
	internal void display(){
		
		bool t = true;
		Node looper = this.top;
		while(t){
			
			Console.WriteLine("{0}",looper.data);
			if(looper.next == null)
				t= false;
			else
				looper = looper.next;
		}
	}
}

public class StackLinkedList
{
	public static void Main()
	{
		LinkedList l1 = new LinkedList();
		l1.push(10);l1.push(20);
		l1.display();
		l1.pop();
		l1.display();
		
		
	}
}