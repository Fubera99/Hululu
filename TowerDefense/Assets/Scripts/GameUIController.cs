using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class GameUIController : MonoBehaviour
{
    public VisualElement StatsVisualElement;
    public Button PauseMenuButton;
    public Label PlayerLabel;
    public Label TurnsLabel;
    public Label BuildAttackLabel;
    public Label GoldCounterLabel;
    
    public VisualElement PauseMenuVisualElement;
    public Button BackButton;
    public Button BackToMenuButton;
    
    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        
        StatsVisualElement = root.Q<VisualElement>("StatsVisualElement");
        PauseMenuVisualElement = root.Q<VisualElement>("PauseMenuVisualElement");
        PauseMenuButton = root.Q<Button>("PauseMenuButton");
        PlayerLabel = root.Q<Label>("PlayerLabel");
        TurnsLabel = root.Q<Label>("TurnsLabel");
        BuildAttackLabel = root.Q<Label>("BuildAttackLabel");
        GoldCounterLabel = root.Q<Label>("GoldCounterLabel");
        
        PauseMenuButton.clicked += PauseMenuButtonClicked;

        PauseMenuVisualElement = root.Q<VisualElement>("PauseMenuVisualElement");
        BackButton = root.Q<Button>("BackButton");
        BackToMenuButton = root.Q<Button>("BackToMenuButton");

        BackButton.clicked += BackButtonClicked;
        BackToMenuButton.clicked += BackToMenuButtonClicked;
        
        PauseMenuVisualElement.visible = false;
    }

    void PauseMenuButtonClicked()
    {
        PauseMenuVisualElement.SetEnabled(true);
        PauseMenuVisualElement.visible = true;
        StatsVisualElement.SetEnabled(false);
        StatsVisualElement.visible = false;
    }

    void BackButtonClicked()
    {
        PauseMenuVisualElement.SetEnabled(false);
        PauseMenuVisualElement.visible = false;
        StatsVisualElement.SetEnabled(true);
        StatsVisualElement.visible = true;
    }

    void BackToMenuButtonClicked()
    {
        SceneManager.LoadScene("MainMenuScene");
    }
}
