# Day 3: Lighting, Materials, and Textures

Welcome back for day 3!  Today we will:

* Learn about lights and add them to our app.
* Learn about materials and textures and add them to our objects.
* Keep making changes to our app to make it our own.

## Directional Lights

Directional lights are applied to your entire scene and simulate parallel rays of light similar to sunlight.  When we created our scene a default directional light was added to the scene.

You can move the light around by:

1. Selecting **Directional Light** in the hierarchy view.

2. Pressing the move button above the hierarchy view.

3. Dragging the light around in the scene view.

Or

1. Selecting **Directional Light** in the hierarchy view.

2. Modifying the position elements of the transform component in the inspector view.

Similarly, you can modify the angle of the lights using the rotation button and scene view, or by modifying the rotation elements of the light's transform.

You can also set the following attributes in the inspector view.

* The color of the lights.
* Whether the light casts shadows and how sharp the shadows are.
* There are other advanced settings that we won't cover here.

## Point Lights

Point lights project rays of light in all directions similar to a bare lightbulb.  Therefore, modifying the rotation of a point light doesn't have an effect.

You can change the following settings for point lights.

* The position of the light.
* The color of the light.
* The intensity of the light.
* Shadow properties.
* Additional advanced properties.

## Spotlights

Spotlights project rays of light in a cone defined by the user.

You can change the following settings for spotlights.

* The position of the light.
* The rotation of the light.
* The color of the light.
* The spot angle, _i.e._, the width of the cone of light.
* The intensity of the light.
* Shadow properties.
* Additional advanced properties.

## A Brief Aside About Advanced Lighting

Lighting is a very complex topic and we could spend the whole week on lighting alone and only scratch the surface.  I will say a few things about advanced lighting so that you can learn more on your own if you're interested.

The lighting that we have used so far is considered real-time lighting.  That means that all of the lighting interactions like color, shadows, and reflections are calculated on the fly while the program is running.  When a scene becomes complex with many lights of different kinds and many objects that the lighting can interact with, calculating the lighting in real-time can be expensive and affect the performance of your application.  Therefore you can use advance techniques like "baking" in lights in scenes where the lighting won't change much.  You can also use hybrids of real-time and baked lighting.  You may have noticed additional objects in the **Light** submenu like **Area Light** and **Light Probe**.  They are used in these more advanced lighting methods.

## Materials

Materials define how your objects look when they interact with lights.  The materials in Unity are very powerful and there are many possible settings and attributes that can be used to make your objects look any way you can imagine.  We'll just be covering a few of the materials attributes, but like lighting, I'll allude to advanced properties at the end that you can go learn more about on your own.

You may have noticed that all of the objects that we've made so far are plain white (or gray).  That is because Unity creates a default material for each object when it's created.  We will now create some new materials to make our game look a bit more realistic.

## Ground Material

1. Click on the **Assets** folder in the project view.

2. Create a new folder named **Materials**.

3. Open the newly created **Materials** folder.

4. Right-click in the blank area and select **Create->Material**.

5. Name the new material **Ground Material**.

6. Select **Ground** in the hierarchy view.

7. Drag the **Ground Material** onto the inspector view.  The new material will replace the default material.

8. You can change the color of the material by selecting **Ground Material** again in the project view and clicking the color box to the right of the Albedo property in the inspector view.  This will bring up a color chooser for you to select a base color for the ground.  I chose a nice green.

9. You can choose the reflectivity of the material by using the **Metallic** slider in the inspector view.

10.  You can also choose the smoothness of the material by using the **Smoothness** slider in the inspector view.  The metallic and smoothness settings work in conjunction to determine how light bounces off of your objects.


## Box Material

Now make a material for your boxes.

1. Open the **Materials** folder.

2. Right-click in the blank area and select **Create->Material**.

3. Name the new material **Box Material**.

4. In the upper right corner of the project view there is a little drop down tab.  Left-click the tab and select **Add Tab->Project**.

5. Drag the new project tab over to the right of the project view so that we have two views of our project folders.

6. In the new tab open the prefabs folder.

7. Drag the **Box Material** onto the **Box** prefab in the project view.  The new material will replace the default material.

Just like the ground material, you can change the albedo, metallic, and smoothness properties of the material.  I chose to make red boxes that are not very reflective or smooth.

## Ball Material

Now make a material for your balls.

1. Open the **Materials** folder.

2. Right-click in the blank area and select **Create->Material**.

3. Name the new material **Ball Material**.

4. Make sure the prefabs folder is open in the second tab of the project view.

5. Drag the **Ball Material** onto the **Ball** prefab in the project view.  The new material will replace the default material.

Just like the previous materials, you can change the albedo, metallic, and smoothness properties of the material. I chose to make blue balls that are smooth and reflective.

## Simple Textures

It's neat that we can change the color and reflectivity of our objects, but real objects have a lot more detail in how they look.  They have patterns, bumps, scratches, etc.  Here we'll make some very simple textures that will allow us to apply patterns to our objects to make them look a little bit more realistic.

## Using a Texture Generator

1. Go to [Texture Generator](http://cpetry.github.io/TextureGenerator-Online/).

2. Choose a texture type.  I chose Brick.

3. Play around with the settings until you get something you like.

4. Choose a texture size.  I would keep it small and chose the default 512x512.

5. Give the file that you will download a name and choose a file format (PNG is fine).

6. Finally download the file to the directory **Assets->Materials** under your project's home directory.

## Drawing Textures

1. Open an image editing application like Photoshop, GIMP, Inkscape, or Paint.

2. Choose an image size that is a power of 2 like 16x16, 32x32, 256x256, etc. depending on how detailed your texture will be.  The larger the size, the more potential for performance issues.

3. Draw your texture.

4. Save the image to the directory **Assets->Materials** under your project's home directory.  Choose a format that Unity supports like PNG or JPG.

## Downloading Textures

1. Google for an image that you are interested in using as a texture.

2. Download the file to the directory **Assets->Materials** under your project's home directory.

3. You may have to use an image editing program to resize the image or convert it into a supported format.

## Add Textures to Your Materials

1. Open the **Materials** folder in the projects view.

2. You should see your saved textures along with the materials that were already there.

3. Select the material you would like apply the texture to.

4. Simply drag the texture image up to the little box to the left of the **Albedo** attribute in the inspector view.

## A Brief Aside About Advanced Materials and Textures

Like lighting, materials are complex and can take years to master.  You probably noticed that there are many attributes in a material's inspector view below **Albedo** that also have an area to drop a texture into.  Attributes like **Metallic**, **Normal Map**, **Height Map**, and so on.  With these textures you can make complex patterns of reflectivity, bumps and scratches, or elevation changes.  If you were to try and model such detail in the geometry of the object it would be very computationally expensive to render your objects.  These different texture maps are efficient shortcuts to take advantage of different parts of what is called the graphics rendering pipeline.

## Customize!

Time to go crazy creating textures and customizing your game!  Here are some suggestions.

* Can you make your blocks look like something from Minecraft?
* If you created other objects with different shapes yesterday, can you create materials for them too?
* Now that you've created different materials with different materials and textures, how does changing the properties of your lights change how your objects look?

