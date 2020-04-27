﻿using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class FaceManager : Singleton<FaceManager>
{
    public Text face;
    public AudioSource sounds;
    public AudioClip needToGetWallet;

    public static UnityEvent GetFaceEvent(UnityAction call)
    {
        UnityEvent faceEvent = new UnityEvent();
        faceEvent.AddListener(call);
        return faceEvent;
    }

    public void ChangeWakeUpFace()
    {
        ChangeFace("(っ﹏-) .｡o");
    }

    public void ChangeNormalFace()
    {
        ChangeFace("(o´ω`o)ﾉ");
        PlayerState.isWearingClothes = true;
    }

    public void ChangeNormalFace2()
    {
        ChangeFace("(o°ω°o)");
    }

    public void ChangeTerrifyFace()
    {
        ChangeFace("Σ(ﾟДﾟ；≡；ﾟдﾟ)");
    }

    public void ChangeFace(string text)
    {
        if (face != null)
        {
            face.text = text;
        }
    }

    public void ChangeDoubtFace()
    {
        ChangeFace("( ˘•ω•˘ ).oOஇ");
        sounds.PlayOneShot(needToGetWallet);
    }
}
