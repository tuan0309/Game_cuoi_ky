using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI textTimer;
    int gameMode = 0;
    public int timer;

    public WinPanel winPanel;

    private void Start()
    {
        gameMode = PlayerPrefs.GetInt("gameMode");
        StartCoroutine(StartTimer());
        var winPanel = FindObjectOfType<WinPanel>();
    }

    IEnumerator StartTimer()
    {
        int showTimer = 0;
        int maxTimer = 10;
        if (gameMode == 0) maxTimer = 600;
        int second, minute;
        while (true)
        {
            timer++;
            if (gameMode == 0)
            {
                showTimer = maxTimer - timer;
                if (timer >= maxTimer)
                {
                    // Win condition reached
                    // Use the WinPanel instance assigned in the Inspector
                    winPanel.Show();
                    yield return new WaitForSeconds(1f);
                    // Implement additional win logic here
                }
            }
            else
            {
                showTimer = timer;
            }

            second = showTimer % 60;
            minute = (showTimer / 60) % 60;
            textTimer.text = minute.ToString() + ":" + second.ToString();
            yield return new WaitForSeconds(1f);
        }
    }
}
