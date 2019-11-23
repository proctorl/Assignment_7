using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropdownValue : MonoBehaviour
{
    List<string> difficulty = new List<string>() { "Word Color", "white", "yellow", "green" };

    public Dropdown dropdown;
    public static int myIndex;

    public void Dropdown_IndexChanged(int index)
    {
        myIndex = index;
    }

    private void Start()
    {
        PopulateList();
    }

    void PopulateList()
    {
        dropdown.AddOptions(difficulty);
    }
}
