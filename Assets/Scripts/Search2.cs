using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Text.RegularExpressions;

public class Search2 : MonoBehaviour
{
    public GameObject contentholder;
    public GameObject[] Element;
    public GameObject SearchBar;
    public int totalelements;

    // Start is called before the first frame update
    void Start()
    {
        totalelements = contentholder.transform.childCount;
        Element = new GameObject[totalelements];

        for (int i = 0; i < totalelements; i++)
        {
            Element[i] = contentholder.transform.GetChild(i).gameObject;
        }
    }

    public void search()
    {
        string searchtext = SearchBar.GetComponent<TMP_InputField>().text.ToLower(); // Convert search text to lowercase for case-insensitive matching

        foreach (GameObject ele in Element)
        {
            string elementText = ele.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text.ToLower(); // Convert element text to lowercase for case-insensitive matching

            // Check if the element text contains the search text
            bool match = elementText.Contains(searchtext);

            ele.SetActive(match);
        }
    }
}
