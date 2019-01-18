using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using Zadatak_4___A_star;

public class Program : MonoBehaviour {

    Maze m;
    int xSize, ySize;
    private InputField inputFieldPath;
    private Text tbIspis;
    private void Start()
    {
        inputFieldPath = GameObject.Find("putanja").GetComponent<InputField>() as InputField;
        tbIspis = GameObject.FindGameObjectWithTag("ispis").GetComponent<Text>() as Text;
//#if !UNITY_EDITOR
            inputFieldPath.Select();
            inputFieldPath.ActivateInputField();
        //#endif
    }

    public void btnUcitajLabirint_Click()
    {
        tbIspis.text = "Unesite putanju do .txt datoteke";
        //string path = EditorUtility.OpenFilePanel("Select labyrinth to solve", "", "txt");
        string path = inputFieldPath.text;

        GetLabyrinthSize(path);

        if(xSize <= 0 || ySize <= 0 || xSize > 100 || ySize > 100)
        {
            tbIspis.text = "Nije postavljena veličina labirinta u prvi red (ex. '22;11', x;y)";
            return;
        }
        m = new Maze(xSize, ySize);
        m.LoadMazeFromFile(path);
        tbIspis.text = "Nije učitana datoteka";
        printMaze(Maze.M, xSize, ySize);
    }

    private void GetLabyrinthSize(string filePath)
    {
        string line;

        System.IO.StreamReader file =
            new System.IO.StreamReader(filePath);
        line = file.ReadLine();
        xSize = int.Parse(line.Split(';')[0]);
        ySize = int.Parse(line.Split(';')[1]);

        file.Close();
    }

    public void btnRijesiLabirint_Click()
    {
        inputFieldPath.Select();
        inputFieldPath.ActivateInputField();

        tbIspis.text = "Button riješi labirint";
        m.Search();

        Cell temp = Maze.End;
        while (temp.Parent != null)
        {
            temp.Character = '.';
            temp = temp.Parent;
        }
        printMaze(Maze.M, Maze.XSize, Maze.YSize);
    }

    private void printMaze(Cell[,] maze, int x, int y)
    {
        tbIspis.text = "";
        for (int i = 0; i < y; i++)
        {
            for (int j = 0; j < x; j++)
            {
                tbIspis.text = tbIspis.text + maze[j, i].Character;
            }
            tbIspis.text = tbIspis.text + "\n";
        }
    }
}
