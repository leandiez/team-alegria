using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Audio;

public class menu_opciones : MonoBehaviour
{    
    [System.Serializable]
    public class resolution_item
    {
        public int horizontal, vertical;

    }
    //elegir resoluciones
    public List<resolution_item> resolutions = new List<resolution_item>();
    private int selected_resolution;

    public TMP_Text resolutionlabel;
    public Toggle PantallaCompletaTog;
    private bool found_Resolution = false;

    public AudioMixer theMixer;
    public TMP_Text masterLabel, musicLabel, efectosLabel;
    public Slider masterSlider, musicSlider, efectosSlider;

    public void Start()
    {
        //busca entre la lista de resoluciones la resolucion de la pantalla del jugador y si logro encontrar un coicidencia se coloca automaticamente
        for (int i=0; i<resolutions.Count; i++)
        {
            if(Screen.width==resolutions[i].horizontal && Screen.height == resolutions[i].vertical)
            {
                found_Resolution = true;
                selected_resolution = i;
                updateResolutionLabel();

            }
        }

        //si en la busqueda de resoluciones no encuentra una conicidencia, se adapta a la resolución de la pantalla del jugador
       if (found_Resolution == false)
        {
            resolution_item new_resolution = new resolution_item();
            new_resolution.horizontal = Screen.width;
            new_resolution.vertical = Screen.height;

            resolutions.Add(new_resolution);
            selected_resolution = resolutions.Count - 1;

            updateResolutionLabel();

        }

    }

    public void resolution_left()
    {
        selected_resolution--;

        if (selected_resolution < 0)
        {
            selected_resolution = 0;

        }
        updateResolutionLabel();

    }

    public void resolution_right()
    {
        selected_resolution++;

        if (selected_resolution > resolutions.Count - 1)
        {
            selected_resolution = resolutions.Count - 1;

        }
        updateResolutionLabel();

    }

    public void updateResolutionLabel()
    {
        resolutionlabel.text = resolutions[selected_resolution].horizontal.ToString() + " x " + resolutions[selected_resolution].vertical.ToString();

    }

    public void ApplyChanges()
    {
        Screen.SetResolution(resolutions[selected_resolution].horizontal, resolutions[selected_resolution].vertical, PantallaCompletaTog.isOn);

    }

    public void setMasterVol()
    {

        masterLabel.text = Mathf.RoundToInt(masterSlider.value +100).ToString();

        theMixer.SetFloat("Master", masterSlider.value);

    }

    public void setEfectosVol()
    {

        efectosLabel.text = Mathf.RoundToInt(efectosSlider.value + 100).ToString();

        theMixer.SetFloat("Efectos", efectosSlider.value);

    }

    public void setMusicVol()
    {

        musicLabel.text = Mathf.RoundToInt(musicSlider.value + 100).ToString();

        theMixer.SetFloat("Musica", musicSlider.value);

    }
}