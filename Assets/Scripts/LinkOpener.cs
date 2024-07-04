using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkOpener : MonoBehaviour
{
   public void Open_Offical_Website()
    {
        string url = "https://attock.comsats.edu.pk/";
        Application.OpenURL(url);
    }

    public void Open_GoogleMaps()
    {
        string url = "https://maps.app.goo.gl/K6EWKkcVKisJBWvs6";
        Application.OpenURL(url);
    }

    public void Open_Portal()
    {
        string url = "https://atk-cms.comsats.edu.pk:8090/";
        Application.OpenURL(url);
    }
    public void Open_Gallery()
    {
        string url = "https://attock.comsats.edu.pk/Photo/Gallery.aspx";
        Application.OpenURL(url);
    }
    public void Open_Facebook()
    {
        string url = "https://www.facebook.com/CUIAttockofficial/";
        Application.OpenURL(url);
    }
    public void Open_Instagram()
    {
        string url = "https://www.instagram.com/cuiattockofficial/";
        Application.OpenURL(url);
    }





}
