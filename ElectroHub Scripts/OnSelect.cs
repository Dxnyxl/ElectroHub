using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class OnSelect : MonoBehaviour
{
    
    public void Alevel()
    {
        SceneManager.LoadScene("Course overview");
    }
    public void LogicSystems()
    {
        SceneManager.LoadScene("Logic Systems");
    }
    public void SubmitTicketScene()
    {
        SceneManager.LoadScene("Make A Ticket");
    }
    public void PastPapers()
    {
        SceneManager.LoadScene("Past Paper Questions");
    }
    public void VideoTutorial()
    {
        SceneManager.LoadScene("Video");
    }
    public void TopicNotes()
    {
        SceneManager.LoadScene("Topic Notes");
    }
    public void CourseSelector() {
        SceneManager.LoadScene("Course selector");
    }

}

