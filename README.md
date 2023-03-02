# my-fabulous-creatures-api
From an egg to a dangerous creature, discover the multiple aspects of your little.


<details open="open">
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
    </li>
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#prerequisites">Prerequisites</a></li>
        <li><a href="#installation">Installation</a></li>
      </ul>
    </li>
    <li><a href="#usage">Usage</a></li>
    <li><a href="#roadmap">Roadmap</a></li>
    <li><a href="#contributing">Contributing</a></li>
    <li><a href="#license">License</a></li>
  </ol>
</details>

## About The Project

My Fabulous Api Creatures is a web API that allows you to retrieve creatures from a local database, in fact there are static images assets.
Its primary purpose is to be used in a Discord bot, but it can be used in any other project. (check out the [Aleks Bot](https://github.com/TalentHubDiscord/aleks-bot) for an example)

**Note**: This project is still in development, and may not be stable, but it is already usable and can be used in your projects. However, the drawings used in this API are not mine and you don't have the right to modify them without permission. Please respect the artist's rights.
You can find the artist's instagram [here](https://www.instagram.com/_aka_skies_/).

The goal is to create a complete life cycle for a creature, from an egg to a dangerous creature, discover the multiple aspects of your little. You will be able to feed it, play with it, and even make it evolve.

A creature is associated to an egg, which has different states about how it's evolving. The egg will evolve into a creature, which will evolve into a dangerous creature. The dangerous creature will evolve into a legendary creature.
The creature then, will be able to grow up, from baby to adult.

That's the current state of the project, but it will evolve over time. Do not hesitate to suggest new features or to contribute to the project by creating a pull request or by opening an issue.

## Getting Started

To get a local copy up and running follow these simple steps.

### Prerequisites

You need to have the following software installed on your computer:

* [.NET 7.0 SDK](https://dotnet.microsoft.com/download/dotnet/7.0)

### Installation

1. Clone the repo
   ```sh
   $ git clone https://github.com/TalentHubDiscord/my-fabulous-creatures-api.git
   ```
2. Change directory
   ```sh
   $ cd my-fabulous-creatures-api
   ```
   
3. Install the dependencies
   ```sh
    $ dotnet restore
    ```
   
4. Run the project
   ```sh
   $ dotnet run
   ```

## Usage

There are currently 2 endpoints available:

* `/api/v1/Creature` : Returns a list of all creatures
* `/api/v1/Egg` : Returns a creature by its id

Query parameters for the `/api/v1/Egg` endpoint:
* `Type` : The type of the egg.
* `Cracks`: The state of the egg.

Query parameters for the `/api/v1/Creature` endpoint:
* `Type` : The type of the creature.
* `Age`: The state of the creature.

## Roadmap

- [x] Retrieve a creature from its type
- [x] Retrieve a creature from its age
- [x] Retrieve an egg from its type
- [x] Retrieve an egg from its cracks
- [ ] Retrieve a creature from its name
- [ ] Retrieve an egg from its name
- [ ] Retrieve a random creature
- [ ] Retrieve a random egg
- [ ] Add cosmetic items
- [ ] Add a shop
- [ ] Add a leaderboard
- [ ] Add a profile (with canvas)
- [ ] Add a background
- [ ] Add animations

Eventually, I would like to add a web interface to manage the creatures and the eggs.

## Contributing

Contributions are what make the open source community such an amazing place to be learn, inspire, and create. Any contributions you make are **greatly appreciated**.
This web API is pretty simple, but it can be improved. If you want to contribute, you can do it by opening an issue or by creating a pull request.
**__#first-contributions-friendly__**

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/RetrievingRandomCreature`)
3. Commit your Changes (`git commit -m 'Add some RetrievingRandomCreature'`)
4. Push to the Branch (`git push origin feature/RetrievingRandomCreature`)
5. Open a Pull Request
6. Wait for the review

## License

Distributed under the MIT License. See `LICENSE` for more information.

