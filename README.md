version https://git-lfs.github.com/spec/v1
oid sha256:54fdc5ededb42e70338cefac354e7f7a584bbba2d309e15ed0910da5c24d36e3
size 3011
version https://git-lfs.github.com/spec/v1
oid sha256:236e8f0c2aeaf55b7b162122b6931bee1a76d048011fb9e2a407747590243de2
size 96
# Mixed Reality and Tangible Interactions - Project Report

## About the Project
This project aims to bridge the tactile world of handcrafted crochet art with the immersive realm of augmented reality (AR). By using crocheted patterns as AR markers, the application creates an innovative platform where the user can interact with an AR object spawned upon the crocheted artifact. 

It is both a creative exploration of technology and a celebration of traditional craft. For instance, a crocheted butterfly pattern generates a lifelike virtual butterfly that moves within the AR space and can be interacted with. Also, the butterfly changes color when specific targets are observed.

---

## Steps:

### 1. Prerequisite:
- **Download and install Unity software:** Unity 2022.3 LTS version via Unity Hub along with everything part of Unity Android Build Support tools.
- **Create a Vuforia account:** Go to [Vuforia Developer Portal](https://developer.vuforia.com/home) and "Register" there.
- **Download the Vuforia Engine:** Version 10.27 (Unity package).
- **Install the Vuforia Engine:** In Unity, go to the Unity Asset Store or download it directly from Vuforia.

### 2. Unity Setup:
- Open the Unity software.
- Create a new Unity project (ensure you choose a 3D project).
- Import the Vuforia Engine by going to `Window` > `Package Manager`, select the Vuforia package, and install it.

### 3. Configure Vuforia:
- In Unity, go to `Edit` > `Project Settings` > `Player`, and under the **XR Settings**, check **Vuforia Augmented Reality**.
- Go to the `Vuforia Configuration` inside `AR camera` object in the scene.
- Select your camera in the Vuforia Configuration settings.

### 4. Add AR Components:
- Drag the **AR Camera** prefab from the Vuforia Engine into your scene.
- Add a **Image Target** or **Model Target** to use the crocheted patterns as AR markers.
- Assign the appropriate marker (crocheted object) and AR content (e.g., butterfly model) to the image target.

### 5. Build and Run:
- Go to `File` > `Build Settings`, select **Android** and click **Switch Platform**.
- Ensure Android SDK and JDK are properly configured under `Preferences` > `External Tools`.
- Connect your Android device and enable USB debugging.
- Build the application by clicking **Build and Run** to deploy it to your device.

### 6. Test and Interact:
- Once the app is running on your Android device, point the camera at the crocheted pattern.
- The virtual butterfly will appear and can be interacted with in the AR space.
- Install the .apk file on your android device
- Launch the application after installation is complete
- Once the app is running on your Android device, point the camera at the crocheted pattern, the butterfly should spawn.
- Point at the different multi target cubes(red, blue and yellow) to change colour of the butterfly's wings.
### 7. Image Targets:
![image](https://github.com/user-attachments/assets/7b5c68b4-b430-4c04-bc71-de88babab894)
![WhatsApp Image 2024-12-15 at 20 38 31_933da04d](https://github.com/user-attachments/assets/28826c0a-d5fa-4410-a018-6c84315a4bb9)
Image Target
