Pour cette application, la partie simulation en solo a été réalisée et le joueur peut simuler une partie avec différents bots qui répondront aux questions et essayeront de deviner le nombre de réponses oui.
Cependant la partie en ligne n'a pas eu le temps d'être réalisée et c'est dans celle ci que devaient intervenir les mécanismes de synchronisation et les relations clients-serveur. Pour les mécanismes de synchronisation j'avais pour idée d'attendre que tous les joueurs répondent à la question et que leur réponses soient envoyés, cela aurait permis d'attendre qu'un évènement se produise avant de réaliser les différents actions nécessaires à la suite de la partie. Je continuerai d'essayer de développer cette partie de l'application même si la deadline est passée afin d'être sur de maitriser les compétences nécessaires à la réalisation de ce projet.
Concernant les design patterns, j'ai utilisé le MVVM pour simplifier le développement de mon application cependant, il n'est pas complet car dans le model, ce sont surtout les sockets qui interviennent si j'ai bien compris.
De plus, un des problèmes de mon application est que pour l'instant après une partie, je n'ai pas encore réussi à clear les différents joueurs et donc le nombre de joueurs dans ma datagrid.
La page HOST n'est pas encore fonctionnelle car la relation client-serveur n'est pas encore fonctionnelle. Le design peut paraître vide mais j'aime bien l'application épurée comme elle est juste avec le logo CESI.
Merci!