# ExtractCoordinates - HTCvive

Application for the Accuracy and Repeatability Tests in HTC Vive in comparison with OptiTrack, developed in Unity (version 2019.4.2f1).

## Application Overview
In other to successfully send the hand coordinates to ROS, some steps have to be followed:
1. Definition of the desired coordinate system (below is explained how to set it up).
2. Connect the application to ROS.
3. Start sending the coordinates to ROS (publishes to the ROS topic /HLposition or /HTCposition). It is also possible to stop sending the information to ROS by clicking the *Stop* button.

![extract_coord_overview](https://user-images.githubusercontent.com/76999213/120810271-c810f500-c542-11eb-91e7-3d940c39a550.png)

### Referential Definition
The application defines automatically a coordinate system when it is launched. So, in order to be able to compare directly the coordinates from OptiTrack and HL2/HTC, it was necessary to define a different referential to match the one from OptiTrack. Because the HL2/HTC software does not allow to define a secondary referential, it was necessary to do some workarounds. The simplest way found was to place an object (a cube in this specific case) in the origin of the coordinate system and then calculate the hand coordinates in relation to that object. To define the cube's position and orientation, it was used the OptiTrack instrument for ground plane definition so that the coordinate systems would be exactly the same.

#### HoloLens 2
- First, in order to define the referential's origin, the user clicks on the interface button *Set Referential*, suggesting that is ready to start defining the referential.
- After clicking the *Set Coordinate*, the user has five seconds to place the right index finger tip at the OptiTrack coordinate system origin. When that time is up, the system will save the coordinates where the right index finger tip is, as the referential's point of origin.
- Then, the user clicks the button again and has five seconds to place the finger at the second point, which defines the point in the X axis.
- The same happens with the third point to define the Z axis.
- Lastly, the user clicks in the button again to confirm that the referential is correctly set and a cube appears at the defined origin with the specified orientation.

![ref_def_hl_coord](https://user-images.githubusercontent.com/76999213/120810343-dbbc5b80-c542-11eb-993b-5ff67f37a29c.png)

#### HTC Vive
- First, in order to define the referential's origin, the user clicks with the controller on the interface button *Set Referential*, suggesting that is ready to start defining the referential.
- After clicking the button *Set Coordinate*, the user has five seconds to place upside down the right controller at the OptiTrack coordinate system origin. When that time is up, the system will save the coordinates where the controller is, as the cube's point of origin.
- Then, the user clicks the button again and has five seconds to place the controller at the second point, which defines the point in the X axis.
- The same happens with the third point to define the Z axis.
- Lastly, the user clicks in the button again to confirm that the referential is correctly set and a cube appears at the defined origin with the specified orientation.

![ref_def_htc_coord](https://user-images.githubusercontent.com/76999213/120810387-e70f8700-c542-11eb-8d77-4321a94c7c27.png)

## Author
Inês de Oliveira Soares (ines.o.soares@inesctec.pt | up201606615@up.pt)
- Master Student - Electrical and Computer Engineering @ FEUP
- Master Thesis Development @ INESC TEC
