using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Linq;

public class ReadFromFile : MonoBehaviour
{

    private void Start()
    {
        // load the file from the file location
        string readFromFilePath = Application.streamingAssetsPath + "/Recall_Chat/" + "Test" + ".txt";

        // read the file
        List<string> fileLines = File.ReadAllLines(readFromFilePath).ToList();

        // loop through all the lines in the file
        foreach (string line in fileLines)
        {
            // loop through all the begining numbers of each line
            if (line[0].ToString() == "0")
            {
                // if the starting number is a 0 then dont place a block
                Debug.Log("No Block");
            }
            else if (line[0].ToString() == "1")
            {
                // if the starting number is a 1 then place a difficulty 1 block
                Debug.Log("Easy Block");
            }
            else if (line[0].ToString() == "2")
            {
                // if the starting number is a 1 then place a difficulty 2 block
                Debug.Log("Med Block");
            }
            else if (line[0].ToString() == "3")
            {
                // if the starting number is a 1 then place a difficulty 3 block
                Debug.Log("Hard Block");
            }


            // loop through all the second numbers of each line
            if (line[1].ToString() == "0")
            {
                // if the second number is a 0 then dont place a block
                Debug.Log("No Block");
            }
            else if (line[1].ToString() == "1")
            {
                // if the second number is a 1 then place a difficulty 1 block
                Debug.Log("Easy Block");
            }
            else if (line[1].ToString() == "2")
            {
                // if the second number is a 1 then place a difficulty 2 block
                Debug.Log("Med Block");
            }
            else if (line[1].ToString() == "3")
            {
                // if the second number is a 1 then place a difficulty 3 block
                Debug.Log("Hard Block");
            }



            // loop through all the last numbers of each line
            if (line[2].ToString() == "0")
            {
                // if the last number is a 0 then dont place a block
                Debug.Log("No Block");
            }
            else if (line[2].ToString() == "1")
            {
                // if the last number is a 1 then place a difficulty 1 block
                Debug.Log("Easy Block");
            }
            else if (line[2].ToString() == "2")
            {
                // if the last number is a 1 then place a difficulty 2 block
                Debug.Log("Med Block");
            }
            else if (line[2].ToString() == "3")
            {
                // if the last number is a 1 then place a difficulty 3 block
                Debug.Log("Hard Block");
            }
        }
    }
}
