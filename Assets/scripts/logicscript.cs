using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logicscript : MonoBehaviour
{

    public int score = 0;
    public Text scoretext;
    public AudioSource scoreeffect;

    //public AudioSource backgroundmusic;

    public GameObject goverscreen;
    public AudioSource losereffect;

    public GameObject pausebutton;

    public bool gamepaused = false;
    public GameObject pausescreen;

    public AudioSource buttoneffect;

    public int highestscore = 0;
    public Text highscore;

    public GameObject backgroundmusicon;
    public GameObject backgroundmusicoff;

    //Game management like pause or gameover
    public void restartgame()
    {
        Debug.Log("Game restarted");
        buttoneffect.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }

    public void gameoverscreen()
    {
        Debug.Log("Game lost");
        goverscreen.SetActive(true);
        pausebutton.SetActive(false);
        //backgroundmusic.Stop();
        losereffect.Play();
    }

    public void quitgame()
    {
        Debug.Log("Game quitted");
        buttoneffect.Play();
        Application.Quit();
    }

    public void pausegame()
    {
        Debug.Log("Game paused");
        buttoneffect.Play();
        Time.timeScale = 0f; // Pause the game
        gamepaused = true;
        pausescreen.SetActive(true); // Activate the "Paused screen" GameObject
        pausebutton.SetActive(false);
        //backgroundmusic.Pause();


    }

    public void resumegame()
    {
        Debug.Log("Game resumed");
        buttoneffect.Play();
        Time.timeScale = 1f; // Resume the game
        gamepaused = false;
        pausescreen.SetActive(false); // Deactivate the "Paused screen" GameObject
        pausebutton.SetActive(true);
        //backgroundmusic.Play();
    }

    public void musicon()
    {
        Debug.Log("Music toggle on");
        //backgroundmusic.volume = 0.1f;
        backgroundmusicon.SetActive(true);
        backgroundmusicoff.SetActive(false);
        buttoneffect.Play();
    }

    public void musicoff()
    {
        Debug.Log("Music toggle off");
        //backgroundmusic.volume = 0f;
        backgroundmusicon.SetActive(false);
        backgroundmusicoff.SetActive(true);
        buttoneffect.Play();
    }

    //Score management
    public void updatehighestscore ()
    {
        Debug.Log("Highest score updated");
        highscore.text = "Highest: " + highestscore.ToString();
    }

    public void loadhighscore ()
    {
        Debug.Log("Highest score loaded");
        highestscore = PlayerPrefs.GetInt("Highest",0);
        updatehighestscore();
    }

    public void savehighestscore ()
    {
        Debug.Log("Highest score saved");
        PlayerPrefs.SetInt("Highest: ", 0);
        PlayerPrefs.Save();
        updatehighestscore();
    }

    public void resetscore()
    {
        Debug.Log("Highest score resetted");
        PlayerPrefs.DeleteKey("Highest");
        highestscore = 0;
        updatehighestscore();
        buttoneffect.Play();
    }

    [ContextMenu("Increase score")]
    public void addscore(int pointtoadd)
    {
        score = score + pointtoadd;
        scoretext.text = "Score: " + score.ToString();
        scoreeffect.Play();

        if (score > highestscore)
        {
            highestscore = score;
            savehighestscore();

        }

    }




    // Start is called before the first frame update
    void Start()
    {
        //backgroundmusic.Play();
        loadhighscore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
