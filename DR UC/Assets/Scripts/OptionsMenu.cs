using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class OptionsMenu : MonoBehaviour {


    Resolution[] res;
    public Dropdown resDrop;

    void Start()
    {
        int curResIndex = 0;
        List<string> options = new List<string>();
        res = Screen.resolutions;
        resDrop.ClearOptions();
        for(int i = 0;i < res.Length;i++)
        {
            string option = res[i].width + "x" + res[i].height;
            options.Add(option);
            if(res[i].width == Screen.currentResolution.width && res[i].height == Screen.currentResolution.height)
            {
                curResIndex = i;
            }
        }
        resDrop.AddOptions(options);
        resDrop.value = curResIndex;
        resDrop.RefreshShownValue();
    }

	public void setQuality(int qualIndex)
    {
        QualitySettings.SetQualityLevel(qualIndex);  
    }
    public void setFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }
    public void setResolution(int resolutionIndex)
    {
        Resolution resolution = res[resolutionIndex];
        Screen.SetResolution(resolution.width,resolution.height, Screen.fullScreen);
    }
}
