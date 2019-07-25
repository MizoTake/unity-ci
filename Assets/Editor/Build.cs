using System;
using System.Linq;
using UnityEditor;
using UnityEngine;

public class Build : MonoBehaviour
{
    static void Execute ()
    {
        var scenes = (
            from scene in EditorBuildSettings.scenes where scene.enabled select scene.path
        ).ToArray();
        
        BuildPipeline.BuildPlayer (scenes, Application.dataPath.Replace("Assets", "") + "Build/" +  EditorUserBuildSettings.activeBuildTarget, EditorUserBuildSettings.activeBuildTarget, BuildOptions.None);
    }
}
