using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RaffleSystem : MonoBehaviour
{
    [SerializeField] GameObject wordsListContent;
    [SerializeField] TextMeshProUGUI wordListIntemPrefab;
    [SerializeField] TextMeshProUGUI lastWordDrawnShower;

    string lastWordDrawn;
    List<string> wordsPool = new List<string>(WordsList.Words);
    int randomIndex;

    void Start()
    {
        lastWordDrawn = "";
    }

    public void DrawNextWord()
    {
        if (wordsPool.Count > 0)
        {
            randomIndex = Random.Range(0, wordsPool.Count - 1);
            lastWordDrawn = wordsPool[randomIndex];
            wordsPool.RemoveAt(randomIndex);

            InstantiateNewWordInsideList();
            ShowLastDrawnWord();
        }
        else
            ShowNoMoreWordsMessage();
    }

    private void ShowNoMoreWordsMessage()
    {
        lastWordDrawnShower.text = "Não há mais palavras!";
    }

    void ShowLastDrawnWord() { 
        lastWordDrawnShower.text = lastWordDrawn;
    }

    void InstantiateNewWordInsideList() {
        TextMeshProUGUI lastListedWord = Instantiate(wordListIntemPrefab, wordsListContent.transform);
        lastListedWord.transform.SetSiblingIndex(0);
        lastListedWord.text = wordsListContent.transform.childCount + "- " + lastWordDrawn;
    }
}
