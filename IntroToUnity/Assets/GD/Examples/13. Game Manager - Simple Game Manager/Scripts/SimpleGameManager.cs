using UnityEngine;

public class SimpleGameManager : MonoBehaviour
{
    [SerializeField]
    [Tooltip("The main menu object")]
    private GameObject menuObject;

    [SerializeField]
    [Tooltip("The HUD object")]
    private GameObject hudObject;

    // Start is called before the first frame update
    private void Start()
    {
        // Register with the tick system
        //  TimeTickSystem.Instance.RegisterListener(checkStateTickRate, HandleTick);

        // Show main menu
        ShowMenu();

        // Set the initial state (player and camera positions, etc.)
        StartGame();
    }

    private void OnDestroy()
    {
        //  TimeTickSystem.Instance.UnregisterListener(checkStateTickRate, HandleTick);
    }

    public void StartGame()
    {
        //postion player
        //event to InventoryManager
        //countdown to ToastManager
        //enable input control
    }

    public void RestartGame()
    {
        //reset the player stats

        //reset the camera

        //re-spawn enemies
    }

    public void EndGame()
    {
        //countdown to ToastManager
        //disable input control
        //play animation
        //reset
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
            ToggleMenu();
    }

    #region HUD & Menu

    public void ToggleMenu()
    {
        if (!menuObject.activeSelf)
            ShowMenu();
        else
            HideMenu();
    }

    public void ShowMenu()
    {
        HideHUD();

        Time.timeScale = 0;

        menuObject.SetActive(true);
    }

    public void HideMenu()
    {
        menuObject.SetActive(false);

        Time.timeScale = 1;

        ShowHUD();
    }

    private void HideHUD()
    {
        //    throw new NotImplementedException();
        if (hudObject != null && hudObject.activeSelf)
            hudObject.SetActive(false);
    }

    private void ShowHUD()
    {
        if (hudObject != null && !hudObject.activeSelf)
            hudObject.SetActive(true);

        //   throw new NotImplementedException();
    }

    #endregion HUD & Menu
}