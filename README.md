# Modding Help
> Learn how to start modding in Valheim!

# Publicizing Assemblies
> You can download **CabbageCrow's** Assembly Publicizer [Here](https://github.com/CabbageCrow/AssemblyPublicizer/releases)  
> Navigate to **C:\Program Files (x86)\Steam\steamapps\common\Valheim\valheim_Data\Managed**  
> and drag **assembly_valheim.dll** file over the **AssemblyPublicizer.exe**  
> and you will notice the console popup, check to make sure no errors display and close console.   
> Afterwards, in your **Managed** folder where you dragged the **assembly_valheim.dll** file, you'll notice a new folder  
> **publicized_assemblies** with the new **assembly_valheim.dll** you'll need to reference in your mods project.  
> You can publicize the guiutils and a few others if needed in the future.  
  
  
# Visual Studio
> Create a folder in your Project folder called **Libs**  
> Now you need to add the new **assembly_valheim.dll** file to **Libs** folder.  
> along with a few other files. Let's look at the file list below:  
  
### Navigate to **C:\Program Files (x86)\Steam\steamapps\common\Valheim\BepInEx\core**
> You'll need to move these files below to your **Libs** folder.  
```
BepInEx.dll
0Harmony.dll
```

### Navigate to **C:\Program Files (x86)\Steam\steamapps\common\Valheim\valheim_Data\Managed**
> Copy the files below into your **Libs** folder.  
```
UnityEngine.dll
UnityEngine.CoreModule.dll
UnityEngine.InputLegacyModule.dll
UnityEngine.UI.dll
```

# Referencing
> Now that you have all the DLLs into your projects **Libs** folder  
> Now go to **Visual Studio** => **Project** => **Add Reference**  
> Make sure to highlight all of the DLLs and click Ok!  
  
### Allowing unsafe code
> Since we've technically "hacked" the original **assembly_valheim.dll** and made all  
> Private methods and variables public, we need to instruct Visual Studio to allow our code to execute.  
> Click **Project** => **Project Properties** => **Build**  
Now you'll see **Allow unsafe code** you need to check this option and save.  

