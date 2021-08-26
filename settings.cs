using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
public class settings : MonoBehaviour
{
    public AudioMixer audioMixer;
    Resolution [] reso;
    public Dropdown resolutionDrop;
    public void Start(){
      reso =Screen.resolutions;
      resolutionDrop.ClearOptions();

      List<string>options = new List<string>();
      int currentResoIndex =0;
       for (int i = 0; i<reso.Length;i++){
          string option = reso[i].width +"x"+ reso[i].height;
          options.Add(option);
            if (reso[i].width == Screen.currentResolution.width &&reso[i].height== Screen.currentResolution.height)
            {
                currentResoIndex = i;
            }
       }

            resolutionDrop.AddOptions(options);
            resolutionDrop.value = currentResoIndex;
            resolutionDrop.RefreshShownValue();

    }
    public void setResolution(int resIndex){
        //Resolution res= resolutions[resIndex];
        //Screen.SetResolution(res.width,res.height,Screen.fullScreen);
    }
   public void SetVolume(float volume){
       audioMixer.SetFloat("MyExposedParam",volume);
   }
   public void setQuality(int qIndex){
    QualitySettings.SetQualityLevel(qIndex);
   }
   public void SetFullScreen(bool isFull){
    Screen.fullScreen =isFull;
   }
}
