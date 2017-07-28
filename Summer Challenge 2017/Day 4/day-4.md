# Day 4: User Interface, Reset Scene, and More Customization

Congratulations, you've made it to day 4!  Today we will:

* Add a simple user interface to our game.
* Create a method to reset the game back to the initial scene.
* Continue customizing!

## Adding a Button

So far our only interaction with our scene has been to throw balls at the blocks and knock them down.  Unfortunately, once we've knocked everything down we're done, there's no way to start over.  To fix that, we're going to create a button that will reset the scene back to the state it was in when we started.

1. Right-click in the blank area of the hierarchy view and select **UI->Button**.  When the button is created a **Canvas** object is created too.  More about that later.

2. Select **Button** in the hierarchy view and rename the button to `Reset Button`.

3. Select the **Text** object in the hierarchy view that is a child of the button.

4. Change the **Text** attribute to `Reset`.  You should see that the button is now labeled `Reset`, rather than `Button`.

## Repositioning and Resizing the Button

1. You may have noticed that the new button is huge and was created out of view.  To fix this we'll start by setting the position of the button to `(0, 0, 0)` in the inspector view.

2. Next, set the **Width** to `160` and **Height** to `30`.

Don't worry if the button temporarily disappeared.  The button is attached to the canvas which we also need to resize and reposition.  We'll do that next.

## Setting Up the Canvas

Before we can adjust the position of the canvas we need to put it in the correct coordinate system

1. In the **Canvas** component in the inspector view there is an attribute labeled **Render Mode**.  Click the drop down.

2. Select **World Space**.

3. Finally, drag the **Main Camera** object from the hierarchy view and drop it on the **Event Camera** property in the inspector view.

We'll need to resize the canvas so that it's easier to move around, looks right, and doesn't get in the way of objects in our scene.

1. Select the **Canvas** in the hierarchy view.

2. Set the **Width** attribute in the inspector view to `180` and the **Height** to `50`.

3. Next, set the **X** and **Y** values of the **Scale** attribute both to `0.025`.

Now the canvas is the correct size and the button should be visible.  However, it's in an awkward place so let's move it.

1. Set the **Pos X** attribute to `7` and the **Pos Y** attribute to `2`.

2. Set the **Y** element of the **Rotation** attribute to `25`.

This should put the button off to right a bit and rotate it so that it is close to facing us.  If you've made a lot of modifications it may be in front of other objects or even occluded by them.  You can either change where you put the canvas, or you can move/remove the other objects.

## Adding an Event System

Now we have a button on a canvas, but we need to make it do something.  The way that UI objects and other objects interact is through events.  In order for our button to use events we need to add an event system to our scene.  You may have noticed that we already have an event scene in our hierarchy view.  Unfortunately, it's not the right kind of event system.  We need one that works with Google VR.

1. Select the existing event system in the hierarchy view and delete it.

2. Select the **Assets** folder in the project view.

3. Go to the search bar in the project view and start typing `GvrEventSystem`.

4. Select the **GvrEventSystem** prefab and drag it onto the hierarchy view.

## Making the Button Interactable

Having an event system is not enough.  We need to add a component so that the canvas, and therefore, the button get events to react to.

1. Select the **Canvas** in the hierarchy view.

2. There should be a **Graphic Raycaster** component attached to the canvas.  We won't be needing it so remove it by right-clicking on **Graphic Raycaster** and selecting **Remove Component**.

3. Next, click the **Add Component** button in the inspector view.

4. In the search box start typing `GvrPointerGraphicRaycaster`.

5. Select the **GvrPointerGraphicRaycaster** script and it will be added to the canvas.

## Adding a Raycaster to the Camera

We need one last component to be able to interact with our UI (or any other objects in the scene).  We'll need to add a raycaster to the camera.  What the heck is a raycaster?  Well, in order to tell which objects we're trying to click we need to "cast a ray" along the direction of the camera.  You can think of it like a laser shooting out from your eyeballs and the object that the laser is touching is the object we will interact with.  Conveniently, in our case you can see where that laser would shine because it is exactly where the reticle we set up on day two is visible.  Let's add our raycaster.

1. Select the **Main Camera** in the hierarchy view.

2. Click the **Add Component** button in the inspector view.

3. In the search box start typing `GvrPointerPhysicsRaycaster`.

4. Select the **GvrPointerPhysicsRaycaster** script and it will be added to the canvas.

## Try It Out

Press the play button at the top of the scene view.  Now when you move around you should see that the reticle turns into a larger circle when it encounters the button.  If you click the button though, you'll notice that nothing happens yet.  That's because we haven't hooked the button up to an action for it to perform.  We'll do that next.

## Creating a Reset Controller

To rest the scene we need to create a function to do that.  We'll do that by creating an empty game object and then adding a script to reload.

1. Right-click in the empty part of the hierarchy view and select **Create Empty**.

2. Rename the new game object `ResetController`.

## Adding a Script to Handle Reloading

1. With the **ResetController** object selected in the hierarchy view click the **Add Component** button in the inspector view.

2. Scroll to the bottom and select **New Script**.

3. Name the new script `ResetController`.

4. Open the script for editing.

5. We won't need the `Start` or `Update` methods so delete them.

6. Now add the 'Reload' method below to the script.
	```c#
	public void Reload()
    {
        int scene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
        Time.timeScale = 1;
    }
	```
	
7. We need to add one more statement to the script so that it knows where to find the 'SceneManager'.  Put the following line immediately below the last `using` statement at the top of the script.
	```c#
	using UnityEngine.SceneManagement;
	```

## Connecting the ResetController to the Button

Now we are finally ready to connect the button to an action!

1. Select the button in the hierarchy view.

2. In the **Button** component in the inspector view there is a section labeled **On Click()**.  Drag the **ResetController** from the hierarchy view onto the box that says **None (Object)**.

3. Click on the dropdown labeled **No Function**.

4. Scroll down and select **ResetController->Reload()**

## Try It Out

Press the play button at the top of the scene view.  Now you should be able to knock over some boxes then click on the reset button to set them back up.  For some reason, the lighting can change in the preview emulator mode.  Don't worry, the lighting will not change in you app when it is deployed to your phone.

## Customize!

Now that we know how to interact with objects and create a UI play with the system.  Here are some suggestions.

* Can you think of an action that you'd like to add another button for?
* Now that you know how to change materials and textures can you make your button look cooler?
* Can you figure out how to use a raycaster to refrain from shooting a ball when you want to use the UI?
* Can you get other objects in your scene to act like UI elements?