This repository demonstrates a subtle bug related to mutable variables in F#. The core issue lies in understanding how mutable variables behave within function scopes. The `bug.fs` file contains code that attempts to modify a mutable variable within a function but fails to reflect those changes in the main scope.  The `bugSolution.fs` file provides the corrected implementation.