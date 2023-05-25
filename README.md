## Lean Techniques Showcase: Photo Album, Windows Forms and console app versions
Lean Techniques Photo Album, UI Application

### 1. Prerequisites

1. Download and install [Visual Studio 2022, Community version](https://visualstudio.microsoft.com/vs/).
2. Open VS2022 and open the `PhotoAlbum/PhotoAlbum.sln` solution.

### 2. Running the applications

There are four total projects in this solution:
- `PhotoAlbum`: Windows Forms UI application
- `PhotoAlbumConsole`: Windows Console application
- `PhotoAlbumProvider`: Utility project used by the Windows Forms and Console applications providing a common library to fetch photo album data
- `PhotoAlbumProviderTest`: Project containing unit tests for the `PhotoAlbumProvider` utility

The `PhotoAlbumProvider` project will not be run directly, but we can execute the other three projects.

1. `PhotoAlbum`
    - This project is set as the default project for the solution and should be able to be run simply by clicking the green arrow Start button at the top of the VS2022 interface or by tapping the F5 key.<br />
    ![Start](http://www.holycow2.com/readme_docs/images/start.png)
    - When the app starts up, the user will be presented with a form showing a search box and a "Search" button. Enter an integer into the search box and press "Search." If a valid album ID was entered, the page will display a list of search results for you to browse. Click on any results row to display the associated title and image in a display area on the right side.<br />
    ![Windows Forms](http://www.holycow2.com/readme_docs/images/windows_form_ui.png)
2. `PhotoAlbumConsole`
    - In the project run selection dropdown at the top of the VS2022 interface, select the `PhotoAlbumConsole` application. Click the Start arrow to start up the application.<br />
    ![Console Run](http://www.holycow2.com/readme_docs/images/console_run.png)
    - When the app starts up, follow the prompts to search for album data and display a simple list of results.
3. `PhotoAlbumProviderTest`
    - To run the unit tests, first open the Test Explorer tool by clicking Test >> Test Explorer from the top navigation.
    - In the Test Explorer window, click the "Run All Tests In View" arrow button. All tests should pass.<br />
    ![Test Explorer](http://www.holycow2.com/readme_docs/images/test_explorer.png)

You can also run fully built programs for both versions of the application from the releases in the [Binaries](./Binaries/) folder.