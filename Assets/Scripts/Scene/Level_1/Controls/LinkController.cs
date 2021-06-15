using Assets.Scripts.Scene.Level_1.Models;
using UnityEngine;
using UnityEngine.UI;

public class LinkController : MonoBehaviour
{
    public Text InputText;
    public Text ResultOutput;
    private LinkPair currentLinkPair;

    void Start()
    {
        ResultOutput.text = "...";
        ResultOutput.color = Color.gray;
    }

    public void GenerateLink()
    {
        var inputField = GetComponentInChildren<InputField>();
        currentLinkPair = LinkPresets.Presets[Random.Range(0, LinkPresets.Presets.Count)];
        inputField.text = Random.Range(0,2) == 0 ? currentLinkPair.Correct : currentLinkPair.Incorrect;
        ResultOutput.text = "...";
        ResultOutput.color = Color.gray;
    }

    public void CheckForAnswer(bool answer)
    {
        if (currentLinkPair == null)
            return;
        var correctAnswer = InputText.text == currentLinkPair.Correct;

        if (answer == correctAnswer)
        {
            ResultOutput.text = "бепмн";
            ResultOutput.color = Color.blue;
        }
        else
        {
            ResultOutput.text = "мебепмн";
            ResultOutput.color = Color.red;
        }
    }
}
