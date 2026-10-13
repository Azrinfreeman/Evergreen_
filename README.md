# Evergreen — Virtual Experiment Prototype

A Unity educational prototype with interactive experiment scenes, procedural UI, and Malay self-assessment quizzes. This is the earlier `Evergreen_` repository; [Evergreen-STEM](https://github.com/Azrinfreeman/Evergreen-STEM) is a separate project revision and is not substituted by these files.

## Tracked implementation

- Experiment activities using draggable UI objects, 2D triggers, object visibility, and next-step controls.
- Conditional progression based on scene objects, plus a final action returning to Dashboard.
- Quiz answer feedback with avatar expressions, audio cues, and ten-point rewards for correct responses.
- A quiz-completion prompt and a score display backed by an in-memory field.
- Fourteen enabled scenes: LoginPage, Dashboard, seven Uji Diri quizzes, and experiment scenes akt3–akt7.

Scene names and scripts establish the prototype's structure, not complete scientific simulation or authentication. The presence of LoginPage does not establish a verified account system. Runtime scene wiring and curriculum accuracy remain untested.

## Open the project

1. Install **Unity 2022.3.60f1**, recorded in [ProjectVersion.txt](ProjectSettings/ProjectVersion.txt).
2. Clone the complete repository and add its folder in Unity Hub.
3. Allow [package resolution](Packages/manifest.json) to finish. Declared dependencies include TextMesh Pro 3.0.7, Unity UI 1.0.0, and Samsung Android Adaptive Performance 5.0.0.
4. Review [build settings](ProjectSettings/EditorBuildSettings.asset); LoginPage is the first enabled scene.
5. Inspect Dashboard navigation, experiment references, and quiz data before entering Play Mode or choosing a build target.

No editor import, build, device run, or working deployment is claimed by this documentation review.

## Source guide

| Area | Source |
| --- | --- |
| UI dragging | [DragController.cs](Assets/DragController.cs) |
| Conditional experiment steps | [ConditionalCheck.cs](Assets/ConditionalCheck.cs), [CheckContent.cs](Assets/CheckContent.cs) |
| Next-step and Dashboard return | [NextExperimentController.cs](Assets/NextExperimentController.cs) |
| Beaker trigger interaction | [Bikar7.cs](Assets/Bikar7.cs) |
| Quiz flow and score | [QuestionController.cs](Assets/QuestionController.cs), [ScoreController.cs](Assets/ScoreController.cs) |

See [validation notes](docs/VALIDATION.md) for source observations and suggested checks. Bundled assets and packages retain their respective terms and attribution; this README does not establish redistribution rights or add a project-wide licence.
