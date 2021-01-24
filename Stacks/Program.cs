using System;
using System.Collections.Generic;

namespace Stacks
{
    class Program
    {
        static void Main(string[] args)
        {

            Word myWord = new Word();

            myWord.AddInstruction("Copy");
            myWord.AddInstruction("Pasted");
            myWord.AddInstruction("Changed the Font");
            myWord.AddInstruction("Changed the color of the font");

            string[] newArray = myWord.GetMeTheArrayOfTheInstructions();

            Console.WriteLine(newArray[3]);


            //myWord.PrintInstructions();

            //myWord.ShowMeTheInstructionItemCount();
            //myWord.ShowMeTheRedoInstructionItemCount();

            //myWord.UndoInstruction();

            //myWord.ShowMeTheInstructionItemCount();
            //myWord.ShowMeTheRedoInstructionItemCount();

            //myWord.PrintRedoInstructions();

            //myWord.RedoInstruction();

            //myWord.PrintRedoInstructions();

            //Stack<string> myStackVariable = new Stack<string>();

            //myStackVariable.Push("My first value");
            //myStackVariable.Push("My second value");
            //myStackVariable.Push("My third value");
            //myStackVariable.Push("My fourth value");
            //myStackVariable.Push("My fifth value");

            //string result = myStackVariable.Pop();

            //Console.WriteLine(result);

            //foreach (var item in myStackVariable)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}


public class Word
{
   private Stack<string> instructionStack = new Stack<string>();

    private Stack<string> undoInstructionStack = new Stack<string>();
    public void AddInstruction(string newInstruction)
    {
        instructionStack.Push(newInstruction);
    }

    public void PrintInstructions()
    {
        foreach (var item in instructionStack)
        {
            Console.WriteLine("The instructions are as followed:" + item);
        }
    }

    public void UndoInstruction()
    {
       string lastInstruction = instructionStack.Pop();

        undoInstructionStack.Push(lastInstruction);
    }

    public void PrintRedoInstructions()
    {
        foreach (var item in undoInstructionStack)
        {
            Console.WriteLine("The instructions are as followed:" + item);
        }
    }

    public void RedoInstruction()
    {
        string lastInstruction = undoInstructionStack.Pop();

        instructionStack.Push(lastInstruction);
    }
    
    public void ShowMeTheInstructionItemCount()
    {
        Console.WriteLine("The count of the instructions is: "+ instructionStack.Count);
    }

    public void ShowMeTheRedoInstructionItemCount()
    {
        Console.WriteLine("The count of the instructions is: " + undoInstructionStack.Count);
    }

    public string[] GetMeTheArrayOfTheInstructions()
    {
        string[] newArray = instructionStack.ToArray();

        return newArray;
    }
}
