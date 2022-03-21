using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class MapEditorUIController : MonoBehaviour
{
    public VisualElement ToolsVisualElement;
    public Button MenuButton;

    public VisualElement MenuVisualElement;
    public Button SaveButton;
    public Button LoadButton;
    public Button BackButton;
    public Button BackToMenuButton;
    
    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        
        ToolsVisualElement = root.Q<VisualElement>("ToolsVisualElement");
        MenuVisualElement = root.Q<VisualElement>("MenuVisualElement");
        MenuButton = root.Q<Button>("MenuButton");
        
        MenuButton.clicked += MenuButtonClicked;

        MenuVisualElement = root.Q<VisualElement>("MenuVisualElement");
        SaveButton = root.Q<Button>("SaveButton");
        LoadButton = root.Q<Button>("LoadButton");
        BackButton = root.Q<Button>("BackButton");
        BackToMenuButton = root.Q<Button>("BackToMenuButton");
        
        SaveButton.clicked += SaveButtonClicked;
        LoadButton.clicked += LoadButtonClicked;
        BackButton.clicked += BackButtonClicked;
        BackToMenuButton.clicked += BackToMenuButtonClicked;
        
        MenuVisualElement.visible = false;
    }

    void MenuButtonClicked()
    {
        MenuVisualElement.SetEnabled(true);
        MenuVisualElement.visible = true;
        ToolsVisualElement.SetEnabled(false);
        ToolsVisualElement.visible = false;
    }

    void SaveButtonClicked()
    {
        Debug.Log("Save button clicked.");
    }

    void LoadButtonClicked()
    {
        Debug.Log("Load button clicked.");
    }

    void BackButtonClicked()
    {
        MenuVisualElement.SetEnabled(false);
        MenuVisualElement.visible = false;
        ToolsVisualElement.SetEnabled(true);
        ToolsVisualElement.visible = true;
    }

    void BackToMenuButtonClicked()
    {
        SceneManager.LoadScene("MainMenuScene");
    }
}
