using GD.Tick;
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
        TimeTickSystem.Instance.RegisterListener(checkStateTickRate, HandleTick);

        // Show main menu
        ShowMenu();
    }

    private void OnDestroy()
    {
        TimeTickSystem.Instance.UnregisterListener(checkStateTickRate, HandleTick);
    }

    public void StartGame()
    {
        //postion player
        //event to InventoryManager
        //countdown to ToastManager
        //enable input control
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
        {
            menuObject.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            menuObject.SetActive(false);
            Time.timeScale = 1;
        }
    }

    public void ShowMenu()
    {
        if (!menuObject.activeSelf)
        {
            HideHUD();

            //   Time.timeScale = 0;

            menuObject.SetActive(true);
        }
    }

    public void HideMenu()
    {
        if (menuObject.activeSelf)
        {
            menuObject.SetActive(false);

            //   Time.timeScale = 1;

            ShowHUD();
        }
    }

    private void HideHUD()
    {
        //    throw new NotImplementedException();
    }

    private void ShowHUD()
    {
        //   throw new NotImplementedException();
    }

    #endregion HUD & Menu
}