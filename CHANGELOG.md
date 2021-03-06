### Version List:

[v0.2.7.2 Open-Beta](#v0272-open-beta)  
[v0.2.7.1 Open-Beta](#v0271-open-beta)  
[v0.2.7 Open-Beta](#v027-open-beta)  
[v0.2.6 Open-Beta](#v026-open-beta)  
[v0.2.5 Open-Beta](#v025-open-beta)  
[v0.2.4 Open-Beta](#v024-open-beta)  
[v0.2.3 Open-Beta](#v023-open-beta)  
[v0.2.2 Open-Beta](#v022-open-beta)  
[v0.2.1 Open-Beta](#v021-open-beta)  
[v0.2.0 Open-Beta](#v020-open-beta)  
[v0.1.0 Open-Beta](#v010-open-beta)  
[v0.0.3 Closed-Beta](#v003-closed-beta)  
[v0.0.2 Closed-Beta](#v002-closed-beta)  
[v0.0.1 Closed-Beta](#v001-closed-beta)  

---

### v0.2.7.2 Open-Beta:

1. Fixed Small Issue with VRChat_OnUiManagerInit.

---

### v0.2.7.1 Open-Beta:

1. Use a different approach to console cleaning for better interop with other tools.    (Credits to knah :D)

---

### v0.2.7 Open-Beta:

1. Console no longer has stdout directed to it.    (Credits to knah :D)
2. Removed VRChat Auth Token Hider as it's no longer necessary.    (Credits to knah :D)
3. Added Try Catch to DisableAnalytics Hooks.
4. Updated Il2CppAssemblyUnhollower and Il2CppDumper Versions.    (Credits to knah :D)
5. Implemented potentially dead method detection.    (Credits to knah :D)
6. Exposed new Console Output Handle and assign it to Managed Console Class Output.    (Credits to knah :D)
7. Added Unity 2019.4.3 Dependencies.
8. Bumped Il2CppAssemblyUnhollower Version.

---

### v0.2.6 Open-Beta:

1. Fixed Issue with Logger Timestamp making New Lines.
2. Added Silent Launch Option to Installer.  (Credits to trevtv :P)
3. Fixed Internal Failure caused by DisableAnalytics for certain users.
4. Added Operating System log to startup info.
5. Added ValueTupleBridge to Managed Folder.
6. Added Unified Attributes for both CumPlugins and CumMods.
7. Added Legacy Attribute Support.
8. Fixed Logger Issue with new Unified Attributes.
9. Deprecated CumModLogger, use CumLogger instead.
10. Deprecated ModPrefs, use CumPrefs instead.
11. Added HarmonyInstance Method for easier Unpatching of CumMods and CumPlugins.
12. Create CumLoaderComponent after first scene load in Mono Games.  (Credits to knah :D)
13. Removed Launch Option --CumLoader.devpluginsonly.
14. Removed Launch Option --CumLoader.devmodsonly.
15. Added Launch Option --CumLoader.loadmodeplugins.
16. Added Launch Option --CumLoader.loadmodemods.
17. Fixed Issue with Debug Mode causing Crashes for Some Games.
18. Fixed Issue with Manual Zip overriding Latest Version.
19. Fixed Issue where Manual Zip would get set as Default Selection.
20. Unity Analytics now redirected to localhost, rather than throwing null and exceptions.  (Credits to Emilia :3)
21. CumPlugins are now able to use OnUpdate.
22. CumPlugins are now able to use OnLateUpdate.
23. CumPlugins are now able to use OnGUI.
24. Added GetUnityTlsInterface to Imports.
25. Implemented Native Sided SSL/TLS/HTTPS Fix.
26. Fixed Issue with Support Modules not loading due to Missing Method errors.
27. Fixed Issue with attaching dnSpy on Il2Cpp Games.
28. Replaced mono-2.0-bdwgc.dll with dnSpy Debug dll.
29. Debug Mode will now use LoadFrom instead of Load for breakpoint compatibility.
30. Fixed Crash Issue with DisableAnalytics.
31. Revised Console Logger Callbacks.
32. Fixed Issue with LogCumError not running Callbacks.
33. Deprecated CumLoader.Main use CumLoaderBase or CumHandler instead.
34. Revised Base Cum Handling.
35. Revised IniFile.
36. Fixed Issue with CumPlugins not getting OnUpdate called.
37. Fixed Issue with CumPlugins not getting OnLateUpdate called.
38. Fixed Issue with CumPlugins not getting OnGUI called.
39. CumPlugins are now able to use VRChat_OnUiManagerInit.
40. Fixed Coroutine Queue for Mono Games.
41. Added Launch Option --CumLoader.consoleontop.  (Credits to trevtv :P)
42. Fixed Issue with Assembly Generator not stopping when failing to Download.
43. Escalated Assembly Generator failures to Internal Failures.
44. Fixed Issue where Assembly Generator failures would cause a Crash.
45. Fixed Crash Issue with Unity TLS Fix for some Games.
46. Fixed Issue with Assembly Generator not working for some Users.
47. Fixed Crash Issue with DisableAnalytics for some Games.
48. Fixed Missing NULL Check in DisableAnalytics.  (Credits to Sinai :D)
49. Added Try Catch to Assembly Generator Execution.  (Credits to Samboy :D)

---

### v0.2.5 Open-Beta:

1. Fixed Issue that prevented deserializing structs with TinyJSON.  (Credits to zeobviouslyfakeacc :3)
2. Simplified External Tool Versions.
3. Updated Il2CppDumper to 6.3.3.
4. Added Unity 2019.3.15 Dependencies.
5. Fixed Issue with some Games causing DisableAnalytics to have an Internal Failure.
6. Fixed File Descriptions.
7. Added Icon to AssemblyGenerator.exe.
8. Temporarily Removed the ModSettingsMenu.
9. Temporarily Removed RenderHelper from Support Modules.
10. Fixed Issue with some Games causing DisableAnalytics to have an Internal Failure.
11. Fixed Issue with using Application.unityVersion on some Unity versions.
12. Fixed Issue with using SetAsLastSibling on some Unity versions.
13. Fixed Issue with Release Compilation still saving Debug files to the Output Directory.
14. Added UnityEngine.Il2CppAssetBundleManager to Managed folder to help with Asset Bundle Manipulation on Il2Cpp Games.
15. Installer now properly displays UPDATE instead of INSTALL when updating to a newer version.
16. Added Auto-Update System to Installer.
17. Installer Version Check now Parses the Project File directly.
18. Added Installer Check for Manual Zip (CumLoader.zip) next to the Installer exe.
19. Added UN-INSTALL button to Installer.
20. Added Auth Token Hider for VRChat.
21. Added Console Cleaner for Normal Console
22. Console Cleaner now uses a Harmony Patch instead of unsafe hooking.
23. Improved Unhollower Logging Support.
24. Added Console Log Callbacks to CumLoader.Console.
25. Installer now runs Update Check on Main Thread.
26. Improved Logger System.
27. Fixed Issue with Installer where installing from Manual Zip would cause it to download Latest Version.
28. Temporarily Removed Console Cleaner.

---

### v0.2.4 Open-Beta:

1. Added Error Output Log to Installer.  (Credits to trevtv :P)
2. Use List.Count / Array.Length property instead of Linq's Count() method.  (Credits to zeobviouslyfakeacc :3)
3. Added mechanism to catch when game is open to display additional information.  (Credits to DubyaDude ^.^)
4. Harmony: Remove prefixes after postfixes to fix unpatching patches with __state variables.  (Credits to zeobviouslyfakeacc :3)
5. Fixed Issue with certain Games not having a File Version attached to the EXE.
6. Fixed Small Issue with Thief Simulator.
7. Added MetroUI, Fody, and new revised Dark Theme to Installer.  (Credits to DubyaDude ^.^)
8. UnityCrashHandler now terminates upon running with CumLoader.
9. Added Analytics Disabler.
10. Added Oculus and Facebook Tracking URLs to Analytics Disabler.
11. Added Fallback System for downloading Unity Dependencies needed for Unstripping.
12. Moved LightJson under its own Namespace as CumLoader.LightJson.
13. Installer now correctly displays Download Percentage.  (Credits to charlesdeepk :D)
14. Installer now correctly displays Percentage of Zip Extraction.

---

### v0.2.3 Open-Beta:

1. Added Unity 2019.3.4 Dependencies.
2. Temporarily Fixed Issue with TLS Fix on Certain Il2Cpp Unity Games.
3. Added Launch Option "--CumLoader.agfvunhollower" that Forces the Assembly Generator to use a Specified Version of Il2CppAssemblyUnhollower.
4. Added Location property to the CumMod class.
5. Revised Plugin System.
6. Fixed Issue causing the Assembly Generator to constantly Regenerate every time a Game Launched.
7. Installer now creates the CumPlugins folder.
8. Revised CumMod class to use a new CumBase.
9. All Commonly used Methods and Properties that both CumMod and CumPlugin use have been moved to CumBase.
10. CumPlugins now use their own Attributes.
11. Fixed Issue that let CumPlugins load as CumMods when placed in the CumMods folder and vice-versa.
12. Added better Legacy Version handling for "--CumLoader.agfvunhollower".
13. Added Clearer Display Text to State that DLL Status is Game Compatibility.
14. Also call Harmony patches if IL2CPP methods get called using reflection / il2cpp_runtime_invoke.  (Credits to zeobviouslyfakeacc :3)
15. Fixed Issue with Harmony Patches on Virtual Methods.  (Credits to zeobviouslyfakeacc :3)
16. Improved the Harmony error message if the unhollowed target method is not backed by an IL2CPP method.  (Credits to zeobviouslyfakeacc :3)
17. Fixed Issue with Harmony AccessTools not being able to resolve the no-args constructor if a static constructor exists.  (Credits to zeobviouslyfakeacc :3)
18. Added Support for Mono Debuggers.
19. Mono JIT Domain on Il2Cpp Games should now parse Command Line arguments properly.
20. Forced Installer to reinstall the entire CumLoader folder.
21. Moved all Console and Log Functionality to Native Exports.
22. Updated Il2CppDumper to v6.3.0.
23. Updated Il2CppDumper Config Fix in the Assembly Generator to support Il2CppDumper v6.3.0.
24. Added Temp File Cache to Assembly Generator.
25. Re-enabled Launch Option "--CumLoader.devpluginsonly".
26. Fixed Issue with Certain Mono Games not having OnApplicationStart called.
27. Added Unity 2018.4.2 Dependencies.
28. Fixed Debug Compilation Issue with Console.
29. Added Launch Option "--CumLoader.hidewarnings" that will Hide Warnings from Displaying in Normal Console.  (Debug Console ignores this Launch Option.)
30. Fixed Issue with Support Modules not Unloading their Components properly when OnApplicationQuit is called.
31. Fixed Mistake with Error Catching Console Creation.
32. Log Spam Shield will now Disable itself when CumLoader is using Debug Mode/Console.
33. Log Spam Shield has now been moved to the Native Logger.
34. Added Launch Option "--CumLoader.maxwarnings" for Setting the Max Amount of Warnings for the Log Spam Shield.  (Debug Console ignores this Launch Option, Default is 100, 0 to Disable.)
35. Added Launch Option "--CumLoader.maxerrors" for Setting the Max Amount of Errors for the Log Spam Shield.  (Debug Console ignores this Launch Option, Default is 100, 0 to Disable.)
36. Fixed Memory Leak in Log Spam Shield.
37. Fixed Issue with Exports.
38. Moved DLL Status to its own Enum.
39. Added "Compatibility" property to CumBase.
40. Removed "IsUniversal" property from CumBase.
41. Fixed Issue with Incompatible CumPlugins and CumMods still being used after Logging.
42. Added Unity 2018.4.23 Dependencies.
43. Fixed Issue with Console.h / Console::IsInitialized().
44. Added Tomlyn to ModHandler for TOML Parsing.
45. Moved Tomlyn to its own Namespace under CumLoader.Tomlyn.
46. Added Unity 2018.3.14 Dependencies.
47. Added Unity 2019.2.16 Dependencies.
48. Added Tomlyn to Assembly Generator for TOML Parsing.
49. Cleaned up Config Handling in Assembly Generator.
50. Fixed Issue with Corrupt Tomlyn Lib.
51. Added Dependency Graph System for CumPlugins and CumMods.  (Credits to zeobviouslyfakeacc :3)
52. Fixed Issue with CumPlugins still calling OnPreInitialization even when Incompatible.  (Credits to zeobviouslyfakeacc :3)
53. Added Better Plugin and Mod Cleanup when OnPreInitialization or OnApplicationStart fails.  (Credits to zeobviouslyfakeacc :3)
54. Switched Assembly Generator Config from JSON to TOML.
55. Assembly Generator Config will now be saved to a file named "config.cfg" instead of "config.json".
56. Fixed Issue with Tomlyn in the ModHandler.
57. Added Unity 2020.1.0 Dependencies.
58. Added Temporary Warning for Missing Dependencies.  (Credits to zeobviouslyfakeacc :3)
59. Added CumOptionalDependencies Attribute.  (Credits to zeobviouslyfakeacc :3)
60. Fixed compilation issues on .NET Framework 3.5.  (Credits to zeobviouslyfakeacc :3)
61. Implemented 'Populate' methods to TinyJSON to de-serialize JSON into an existing object.  (Credits to zeobviouslyfakeacc :3)
62. Reimplemented TinyJSON in AssemblyGenerator to be up to date with the one in the ModHandler.
63. Static Linked Runtime Library to Reduce User Issues with Microsoft Visual C++ 2015-2019 Re-distributable.  (Credits to knah :D)
64. Updated Il2CppAssemblyUnhollower Download to v0.4.8.  (Credits to knah :D)
65. Fixed Issue with the RenderHelper of ModSettingsMenu causing Error when SupportModule Unloads their Component.
66. SupportModules now properly Unloads their Component if no CumPlugins or CumMods are loaded.
67. Temporarily Disabled ModSettingsMenu.
68. Added Launch Option "--CumLoader.chromium" to turn the Console Color Magenta.  (Thanks Chromium lol)
69. Fixed Issue with Logger methods with Color Parameter being Overridden by RainbowMode or ChromiumMode.
70. Added Unity 2019.3.5 Dependencies.
71. Added Unity 5.6.7 Dependencies.
72. Added Unity 5.6.3 Dependencies.
73. Changed Launch Option "--CumLoader.chromium" to "--CumLoader.magenta".

---

### v0.2.2 Open-Beta:

1. Downgraded Installer to .NET Framework 4.7.2.  (Credits to knah :D)
2. Added Error Messages to Installer.  (Credits to knah :D)
3. Added Proper Threading to Installer.  (Credits to knah :D)
4. Installer now creates a CumMods folder if none exists.
5. Fixed Installer Form Size.
6. Fixed Issue with Label in Installer Form not Auto-Centering.
7. Fixed Build Information for Installer.
8. Moved CumPlugins to its own separate CumPlugins folder.
9. Installer now creates a CumPlugins folder if none exists.
10. Installer now properly installs the Latest Version instead of a Predetermined Version.
11. Fixed and Re-Enabled --CumLoader.hideconsole.
12. Added Log to Unity Debug to Signify to Developers that a Game has been Modded.
13. Fixed SSL/TLS issue with the Assembly Generator.  (Credits to zeobviouslyfakeacc :3)
14. Fixed Crash Issue with Harmony when Patching Methods Multiple Times or when a Method happens to be null.  (Credits to zeobviouslyfakeacc :3)
15. Made the Loaded CumMods List public.
16. Fix ModPrefs.SaveConfig() overriding previous SetString/Bool/etc calls.  (Credits to knah :D)
17. Fixed SSL/TLS Issue with the Installer.
18. Fixed Issue with Games that don't have Assembly-CSharp.
19. Added a check and a warning for if the OS is older than Windows 7.
20. Updated Il2CppAssemblyUnhollower Download to v0.4.4.  (Credits to knah :D)
21. Cleaned up version.dll.
22. version.dll Proxy will now look for version_original.dll next to the EXE before loading from System32.
23. Small change to version.dll to Prevent Crashing when CumLoader.dll fails to load.
24. Revised Loading System to work without needing Signatures.
25. Reorganized Installation Folder Structure.
26. Fixed Issue with Signature-less System on Pre-2017 Unity Versions.
27. Fixed Issue with Support Modules not loading on Unity Versions older than 5.3.
28. Fixed Issue Loading Mono Module.
29. Fixed Issue with OnApplicationStart getting called even when the Assembly Generator fails.
30. Switched Assembly Generator to Process Based Execution.
31. Fixed Mistake with Assembly Generator not returning false when Execution fails.
32. Fixed Directory Issue with Assembly Generator.
33. Updated Il2CppAssemblyUnhollower Download to v0.4.5.
33. Added new Launch Option --CumLoader.devmodsonly.
34. Added Unity 2018.4.16 Dependencies.
35. CumPlugins now only call OnPreInitialization, OnApplicationStart, OnApplicationQuit, and OnModSettingsApplied.
36. Revised Installer Design.
37. Fixed Issue with Plugin Loading.
38. Fixed OnLevelWasLoaded and OnLevelWasInitialized on Unity Versions lower than 5.3.
39. Fixed GetActiveSceneIndex for Pre2017.2 Support Module.
40. Re-added TinyJSON to ModHandler.
41. Moved TinyJSON to its own Namespace.
42. Fixed SupportModule Issue with Pre-2017 Unity Games.
43. Added Force-Regeneration to Assembly Generator.
44. Added Launch Option --CumLoader.agregenerate.
45. Added Support for CumMods to Harmony Patch using Harmony Attributes.
46. Fixed Issue with Assembly Generator losing output lines.  (Credits to knah :D)
47. Fixed Issue with Assembly Generator failing on paths with spaces.  (Credits to knah :D)
48. Fixed SSL/TLS issues in CumMods for Il2Cpp games.  (Credits to knah :D)
49. Updated Il2CppAssemblyUnhollower Download to v0.4.6.  (Credits to knah :D)
50. Improved String Support for Harmony in Il2Cpp Games.  (Credits to zeobviouslyfakeacc :3)
51. Added Harmony Support for null Il2Cpp Argument Values.  (Credits to zeobviouslyfakeacc :3)
52. Added Harmony Support for ref Types in Il2Cpp Games.  (Credits to zeobviouslyfakeacc :3)
53. Fixed Crash Issue when Exception is thrown from C# Code.  (Credits to zeobviouslyfakeacc :3)
54. Updated Method Targeting in Il2Cpp Games.  (Credits to zeobviouslyfakeacc :3)
55. Installer now Downloads and Installs Required VC Redist.
56. Fixed Invalid Handle Issue with Console Coloring.
57. Added Embedded SharpZipLib to ModHandler.
58. Fixed Zipped Mod Support.
59. Moved SharpZipLib in ModHandler to its own Namespace.
60. Fixed Issue with Zipped Mod Support when using --CumLoader.devmodsonly.
61. Added Launch Option --CumLoader.devpluginsonly.
62. Updated Il2CppAssemblyUnhollower Download to v0.4.7.  (Credits to knah :D)
63. Launch Option --CumLoader.quitfix has been changed to --quitfix.
64. Temporarily Disabled CumPlugins.
65. Temporarily Disabled Launch Option --CumLoader.devpluginsonly.
66. Added Unity 2018.1.9 Dependencies.
67. Added Unity 2019.2.17 Dependencies.
68. Added Unity 2019.2.21 Dependencies.
69. Regenerated Unity Dependencies Zips.
70. Fixed Issue with --CumLoader.devmodsonly.
71. Disabled VC Redist Installation in Installer.
72. Fixed Issue with Installer not running as Administrator.
73. Fixed Installer UAC Issue.

---

### v0.2.1 Open-Beta:

1. Overwrite files when copying freshly generated assemblies.  (Credits to knah :D)
2. Implemented auto-download of required tools for Il2Cpp games.  (Credits to knah :D)
3. Fixed Config Issue causing Assembly to always need to Regenerate.
4. Added an Installer.
5. Fixed Console Display Issue.
6. Temporarily disabled --CumLoader.hideconsole.

---

### v0.2.0 Open-Beta:

1. Fixed Issue with the Console still showing as Closed-Beta.
2. Fixed Issue with not having CumLoader.ModHandler.3.5.dll included in the Release zip.
3. Fixed support for 2018.4.11f1 and Ori and the Will of the Wisps.  (Credits to Hector ^.^)
4. Added 2018.4.11f1 Unity Dependencies.  (Credits to Hector ^.^)
5. Removed Unity Dependencies from Release Build.  (No Longer Needed)
6. Fixed Issue with CumCoroutines not allowing a yield of Coroutine within a Coroutine.  (Credits to Slaynash :3)
7. Revised README.MD.
8. Changed the Hook and Unhook Internal Calls in CumLoader.Imports from internal to public to expose them and allow them to be used by CumMods.
9. Revised CHANGELOG.MD.
10. Added Built-In QuitFix under the Launch Option --CumLoader.quitfix  (For Games like VRChat where the Process Hangs after telling it to Exit)
11. Added Stop Methods to CumCoroutines.  (Credits to Slaynash :3)
12. Fixed Error Handling in CumCoroutines.  (Credits to Slaynash :3)
13. Fixed Issue with CumCoroutines when using Non-Yielding Coroutines.  (Credits to Slaynash :3)
14. Added Support for Method Unstripping through Il2CppAssemblyUnhollower to CumLoader.AssemblyGenerator.
15. Replaced the Doorstop winmm.dll with version.dll.
16. Fixed Compatibility with Il2Cpp Games for 0Harmony in CumLoader.ModHandler.  (Credits to zeobviouslyfakeacc :D)
17. Fixed Issue with 0Harmony not Unpatching Methods when Unloading.
18. Fixed Incompatibility Issue between 0Harmony in CumLoader.ModHandler and Mono Game Support.
19. Added Event Fix for knah's Unhollower Logging.
20. Fixed Null Reference Exception Error when using MethodInfo of Generated Assembly Methods for 0Harmony.
21. Removed NET_SDK.
22. Added Custom Component System for the ModHandler.
23. Added Preload Support for CumMods to Load before the Game Initializes.
24. Added OnPreInitialization for CumMods that Preload.
25. Split support for Mono and Il2Cpp into their own Support Modules.  (Credits to knah :D)
26. Fixed Issue with OnSceneLoad in Il2Cpp Support Module.  (Credits to knah :D)
27. Split CumCoroutines to integrate Support Module support.  (Credits to knah :D)
28. Fixed Issues with needing the ModHandler compiled under a certain .NET Framework.  (Credits to knah :D)
29. Fixed Issue with OnGUI.
30. Fixed Compatibility Issues with SCP Unity.
31. Fixed Issue with version.dll causing UnityCrashHandler to crash.
32. Fixed Compatibility Issues with Hot Dogs, Horseshoes & Hand Grenades.
33. Added Pre 2017 Mono Support Module.
34. Made Normal Console Open by Default.
35. Removed Launch Option "--CumLoader.console".
36. Added Launch Option "--CumLoader.hideconsole" to Hide the Normal Console.
37. Cleaned up Il2Cpp Imports.
38. Cleaned up Mono Imports.
39. Revised Command Line Parsing.
40. Fixed Issue with the Log Cleaner deleting Logs that were not made by CumLoader.
41. Added Launch Option --CumLoader.maxlogs. Sets the Max Logs for the Log Cleaner. Set as 0 to Disable the Log Cleaner.
42. Added Global Exception Handler to the Mono Domain.
43. Added Assembly Generation Integration.
44. Fixed Illegal Characters in Path Error.
45. Temporarily Disabled Zipped Mod Support.
46. Added Log Error Limiter.
47. Re-Enabled Download Links in Mod Logs.
48. Fixed Issue with TestMod not loading on Mono Games.

---

### v0.1.0 Open-Beta:

1. Moved Exports in CumLoader.ModHandler to Mono Internal Calls.
2. Cleaned up Hooking for CumLoader Internals.
3. Added a new cleaner and faster Internal Call Resolver for an Assembly Generator Test.
4. Added 2018.4.19f1 Unity Dependencies.
5. Added additional check for CumLoader.ModHandler needing to be built with .NET 3.5.
6. Added 2018.4.20f1 Unity Dependencies.
7. Changed lists to arrays for caching classes, fields, methods, events, and etc.  (Credits to Kronik ^.^)
8. Changed foreach to statements to for statements for faster iteration.  (Credits to Kronik ^.^)
9. Made certain fields "readonly" (Name, Flags, etc) as it won't be reassigned.  (Credits to Kronik ^.^)
10. Made SDK and Imports class static.  (Credits to Kronik ^.^)
11. Cleaned up CumLoader.ModHandler to use less Linq when possible for improved performance.  (Credits to Kronik ^.^)
12. Added CreateInstance method to Il2Cpp_Class in NET_SDK.Reflection.  (Credits to Kronik ^.^)
13. Fixed SystemTypeToIl2CppClass in NET_SDK.Il2Cpp.
14. Cleaned up TestMod.
15. Added VRChat_OnUiManagerInit for VRChat CumMods.
16. Made CumModGameAttribute work as intended and CumLoader.ModHandler will now only load CumMods marked as Compatible or Universal.
17. Temporarily removed the Guid attribute from the AssemblyInfo of both TestMod and CumLoader.ModHandler.
18. CumMod now properly caches their respective CumModInfoAttribute and CumModGameAttribute.
19. Fixed PointerUtils::FindAllPattern.
20. OnLevelWasLoaded, OnLevelWasInitialized, OnUpdate, OnFixedUpdate, OnLateUpdate, and OnGUI have been fixed and now function properly.
21. Cleaned up LoadLibraryW Hook.
22. Cleaned up and Renamed Exports in CumLoader.ModHandler.
23. Added a HookManager system.
24. Cleaned up and Combined all Internal Hooking into HookManager.cpp and HookManager.h improving compile time.
25. Cleaned up and removed unused or otherwise unneeded includes improving compile time.
26. Used regions to further clean up and organize HookManager.cpp.
27. Added Status Log for when detecting if a Mod is Universal, Compatible, or Incompatible.
28. Cleaned up the Mod Loading functionality of CumLoader.ModHandler.
29. Fixed Issue with the Compatibility Check when using multiple CumModGameAttribute.
30. Fixed Issue with OnLevelWasLoaded and OnLevelWasInitialized getting the wrong Scene Index and only running once then never again.
31. Upgraded CumLoader.ModHandler and TestMod to .NET v4.7.2.  (As requested by Emilia :D)
32. Made CumModController use directly invokable delegates for faster invoking.  (Credits to Kronik ^.^)
33. Removed Unneeded Caching of MethodInfo in CumModController.
34. Added mono-2.0-boehm.dll to Mono Check.
35. Added --CumLoader.rainbow and --CumLoader.randomrainbow as Launch Options.  (As requested by Hordini :3)
36. Redesigned the Logging system to be unified between CumLoader and CumLoader.ModHandler.
37. Colorized Errors in both Consoles.
38. Added the ability for CumMods to set a Color when Logging.
39. Fixed Issue with --CumLoader.rainbow and --CumLoader.randomrainbow not working when using --CumLoader.console.
40. Added Unload Functionality. Entirely unloads CumLoader.  (CumLoader::UNLOAD() or CumLoader.Imports.UNLOAD_CumLoader())
41. Fixed Issue with using 1 or 0 for a boolean in ModPrefs.
42. Fixed Issue with OnUpdate, OnFixedUpdate, and OnLateUpdate invoking too early.
43. Fixed Issue with Unload Functionality not closing either Consoles.
44. Added CumCoroutines to handle Coroutine functionality for CumMods on both Il2Cpp and Mono.  (Credits to knah :D)
45. Fixed Issue with Logger removing Old Logs when it shouldn't.
46. Fixed Issue with OnLevelWasLoaded, OnLevelWasInitialized, and VRChat_OnUiManagerInit when using knah's UnHollower.
47. Fixed Execution Order of OnApplicationStart to run before any of the other Mod Methods.
48. Added Assertion Manager to handle CumLoader Internals.
49. Fixed Issue with CumCoroutines throwing a Cast Exception for knah's UnHollower.
50. Added Support for WaitForFixedUpdate and WaitForEndOfFrame to CumCoroutines.
51. Fixed Issue with CumCoroutines throwing a Missing Method Exception for knah's UnHollower.
52. Added 2019.3.6f1 Unity Dependencies.
53. Fixed Internal Failure issues with RotMG Exalt and Unity 2019.3.6f1.
54. Fixed Internal Failure issues with Pistol Whip and Unity 2019.2.0f1.
55. Fixed Issue with CumLoader.ModHandler complaining about Mod Libraries.
56. Fixed Issue with CumCoroutines processing a yield of null as the same as WaitForFixedUpdate.
57. Made CumMod use directly invokable virtuals and overrides for faster invoking.  (As requested by knah :3)
58. Removed CumModController from CumLoader.ModHandler.
59. Made CumLoader.ModHandler look for the CumMod subclass in the Mod's CumModInfoAttribute instead of searching the entire Assembly.  (As requested by knah :3)
60. Fixed Issue with Logger Imports in CumLoader.ModHandler being passed garbage strings.

---

### v0.0.3 Closed-Beta:

1. General Stability and Optimization Improvements.
2. Added Support for Mono based Games.
3. Added MUPOT Mode which forces Il2Cpp games to run under Mono. This Mode is still extremely Experimental.
4. Logger has been renamed to CumModLogger to prevent conflict with UnityEngine.Logger.
5. Fixed Crash issue when using System.Type in MUPOT Mode.
6. CumModInfo Attribute has been changed to an Assembly Attribute.
7. Fixed Issue with CumModLogger not getting the Mod Name when used outside of the main class.
8. FileInfo in the TestMod has been renamed to BuildInfo so it won't conflict with the System.IO.FileInfo class.
9. Added 0Harmony Integration and Support.
10. Modified CumLoader.ModHandler to use a Component based system in MUPOT Mode and Mono based games.
11. Fixed Issue preventing OnUpdate from being called in MUPOT Mode and Mono based games.
12. Fixed Issue preventing OnApplicationQuit from being called in MUPOT Mode and Mono based games.
13. Fixed Conflict issue triggering Unity's Single Instance function in MUPOT Mode.
14. Added OnLevelWasLoaded, OnLevelWasInitialized, OnUpdate, OnFixedUpdate, OnLateUpdate, and OnGUI for CumMods in MUPOT Mode and Mono based games.
15. Bug that prevented Debug Compilation is now fixed.
16. Fixed Issue that caused Unity Crash Handler to initialize CumLoader twice.
17. Fixed Runtime Initialization issue with Audica that caused crashes.
18. Fixed Execution Order of CumLoader.ModHandler.
19. Fixed Issue with Mono Game Support due to Mono DLL naming.
20. Fixed Issue with Internal Calls through MUPOT Mode.
21. Added better Mod Exception Handling and Logging.
22. Added Dependencies for Unity 2019.1.0b1.
23. Added Dependencies for Unity 2017.4.28f1.
24. Added Dependencies for Unity 2018.4.13f1.
25. Added Dependencies for Unity 2018.1.6f1.
26. Added Dependencies for Unity 2019.2.0f1.
27. Fixed Incompatibility issue with Unity Dependencies between x86 and x64.
28. Added Log in CumLoader.ModHandler for Unity Version.
29. General Code Cleanup.
30. Fixed OnApplicationQuit not working without MUPOT Mode.
31. Fixed Mono Game Support for games that don't use MonoBleedingEdge.  (CumLoader.ModHandler and CumMods must be compiled with .NET 3.5 Framework)
32. Fixed Execution Order when using MUPOT Mode.

---

### v0.0.2 Closed-Beta:

1. Added NET_SDK to be built into CumLoader.ModHandler as the designated Il2Cpp Wrapper.
2. Fixed Issue with CumMods and Logs folders not being in the correct place next to the game's exe.
3. Fixed Issue with the ModPrefs not calling the OnModSettingsApplied method of CumMods.
4. Replaced old ModPrefs debug log message left in from my VRChat mod.
5. Fixed Issue with Audica crashing when trying to use CumLoader.
6. Added Unity 2018.4.6f1 Dependencies.
7. Fixed bug with Launch Options.
8. Fixed Pathing issue that caused games like Boneworks to crash.
9. Fixed Issue where Environment.CurrentDirectory wasn't being set properly.
10. Clean-up and Additions made to NET_SDK.  (Thanks Sc4ad :D)
11. Added SteamVR and OculusVR Dependency DLLs to CumLoader/Managed.
12. Added TestMod to Project Files.
13. Added Attribute StackTrace System to Logger.  (As requested by Camobiwon :3)
14. Replaced Spaces in Names for the Attribute StackTrace System with Underscores.
15. Fixed the bug that caused the Logger from CumLoader.ModHandler to not properly output when using the Debug Console.
16. Added SystemTypeToIl2CppClass method to NET_SDK.Il2Cpp.
17. Crash Issue with Game.DontDestroyOnLoad has been fixed and it now works.
18. Fixed Il2Cpp_Field where SetValue does not function on a instance object.  (Thanks DubyaDude ^.^)
19. Fixed Compile Version conflict with the 2 Consoles.  
CumLoader [DEBUG] & CumLoader.ModHandler [RELEASE]  =  Debug Console  
CumLoader [RELEASE] & CumLoader.ModHandler [DEBUG]  =  Normal Console  
CumLoader [DEBUG] & CumLoader.ModHandler [DEBUG]  =  Debug Console  
CumLoader [RELEASE] & CumLoader.ModHandler [RELEASE]  =  Left up to the Launch Options  

---

### v0.0.1 Closed-Beta:

1) Initial Commit and Rewrite.