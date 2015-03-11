# EndPortalFinder
Find the End Portal in Minecraft!

Eventually we all want to test ourselves in the ultimate challenge, the end.  However, the portal that allows us to travel to the end is usually hidden deep below the surface.  The typical advice on how to find the end portal is: get an eye of ender, throw it, look where it goes and travel in that direction.  Repeat as needed until the eye hovers a bit then dives into the ground.  And so on.  The problem is that eyes of ender are hard to come by and as you toss them about, they have a 20-25% chance of disappearing on each toss.
So I wanted to develop an efficient technique to zero in on the end portal’s location with the least number of throws.  I settled on a triangulation technique that uses the bearings to the portal taken at two points.  The math behind this is pretty basic; each point and bearing defines a line.  The two lines intersect at the portal.  All we have to do is solve a couple of simultaneous equations for the unknown X and Z.  Simple, right?
Well, I know not everyone enjoys solving math problem so I made this little Windows app to make it easy.

