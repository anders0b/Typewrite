<picture><img src="https://github.com/anders0b/Typewrite/assets/142984147/58e4be95-2c27-474d-a0d4-e030a8914deb" alt="logo" width="500"/></picture>

## About
An easy to use blogging and modern platform which allows users to create and administrate their blog online. Built with C#.

## Features
- Easy to use interface, edit and create blog posts on the fly
- Customizable blogs, choose colors and images for a personal layout
- Rate blog posts you read
- Filter and search for blogs by interest and subject, makes it easy to find interesting blogs to read
- Follow your favorite authors by subscribing to blogs
## Entities

### Blog
| Property | Type      | Description            |
| -------- | --------- | ---------------------- |
| Id       | Guid      | Id for blog            |
| Name     | string    | Blog name              |
| Url      | string    | Unique URL for blog    |
| Tags     | List Tag  | Category tags          |
| AuthorId | int       | Author Id for relation |
| Author   | Author    | Author for relation    |
| Posts    | List Post | Related blog posts     |
| ThemeId  | int       | Theme Id               |
| Theme    | Theme     | Theme base for UI      |

### Post
| Property  | Type     | Description                                |
| --------- | -------- | ------------------------------------------ |
| Id        | Guid     | Id for post                                |
| Title     | string   | Post title                                 |
| Content   | string   | Post content                               |
| Url       | string   | Unique URL for post                        |
| ImageUrl  | string   | ImageUrl                                   |
| Published | DateTime | Original publishing date (DateTime.UtcNow) |
| Edited    | DateTime | Latest editing date                        |
| Tags      | List Tag | Category tags                              |
| AuthorId  | int      | Author Id for relation                     |
| Author    | Author   | Author for relation                        |
| BlogId    | int      | Related Blog Id                            |
| Blog      | int      | Related blog                               |
| Rating    | List int | List of ratings, 1-5                       |

### Theme
| Property   | Type   | Description    |
| ---------- | ------ | -------------- |
| Id         | Guid   | Id for post    |
| ColorOne   | string | First color    |
| ColorTwo   | string | Second color   |
| ColorThree | string | Third color    |
| Font       | string | Font selection |

