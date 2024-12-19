PGDMP  !                    |            AnimeTitles    17.2    17.2 #    �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                           false            �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                           false            �           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                           false            �           1262    24697    AnimeTitles    DATABASE     �   CREATE DATABASE "AnimeTitles" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Russian_Russia.1251';
    DROP DATABASE "AnimeTitles";
                     postgres    false            �            1259    24729    animeTitles    TABLE     �  CREATE TABLE public."animeTitles" (
    id integer NOT NULL,
    "idOfType" smallint NOT NULL,
    "idOfGenre" smallint NOT NULL,
    "idModerator" integer,
    "originalName" text NOT NULL,
    "titleName" text NOT NULL,
    "yearOfRelease" smallint NOT NULL,
    description text,
    poster text,
    "countofSeries" smallint,
    duration text,
    "isComplete" boolean NOT NULL,
    studio text NOT NULL
);
 !   DROP TABLE public."animeTitles";
       public         heap r       postgres    false            �            1259    24728    animeTitles_id_seq    SEQUENCE     �   CREATE SEQUENCE public."animeTitles_id_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 +   DROP SEQUENCE public."animeTitles_id_seq";
       public               postgres    false    224            �           0    0    animeTitles_id_seq    SEQUENCE OWNED BY     M   ALTER SEQUENCE public."animeTitles_id_seq" OWNED BY public."animeTitles".id;
          public               postgres    false    223            �            1259    24720 
   animeTypes    TABLE     `   CREATE TABLE public."animeTypes" (
    id smallint NOT NULL,
    "typeOfAnime" text NOT NULL
);
     DROP TABLE public."animeTypes";
       public         heap r       postgres    false            �            1259    24719    animeTypes_id_seq    SEQUENCE     �   CREATE SEQUENCE public."animeTypes_id_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 *   DROP SEQUENCE public."animeTypes_id_seq";
       public               postgres    false    222            �           0    0    animeTypes_id_seq    SEQUENCE OWNED BY     K   ALTER SEQUENCE public."animeTypes_id_seq" OWNED BY public."animeTypes".id;
          public               postgres    false    221            �            1259    24711    genres    TABLE     X   CREATE TABLE public.genres (
    id smallint NOT NULL,
    "genreName" text NOT NULL
);
    DROP TABLE public.genres;
       public         heap r       postgres    false            �            1259    24710    genres_id_seq    SEQUENCE     �   CREATE SEQUENCE public.genres_id_seq
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 $   DROP SEQUENCE public.genres_id_seq;
       public               postgres    false    220            �           0    0    genres_id_seq    SEQUENCE OWNED BY     ?   ALTER SEQUENCE public.genres_id_seq OWNED BY public.genres.id;
          public               postgres    false    219            �            1259    24698    users    TABLE     �   CREATE TABLE public.users (
    id integer NOT NULL,
    "firstName" text NOT NULL,
    "lastNamr" text NOT NULL,
    "dateOfRegistration" date NOT NULL
);
    DROP TABLE public.users;
       public         heap r       postgres    false            �            1259    24701    users_id_seq    SEQUENCE     �   CREATE SEQUENCE public.users_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 #   DROP SEQUENCE public.users_id_seq;
       public               postgres    false    217            �           0    0    users_id_seq    SEQUENCE OWNED BY     =   ALTER SEQUENCE public.users_id_seq OWNED BY public.users.id;
          public               postgres    false    218            3           2604    24732    animeTitles id    DEFAULT     t   ALTER TABLE ONLY public."animeTitles" ALTER COLUMN id SET DEFAULT nextval('public."animeTitles_id_seq"'::regclass);
 ?   ALTER TABLE public."animeTitles" ALTER COLUMN id DROP DEFAULT;
       public               postgres    false    224    223    224            2           2604    24723    animeTypes id    DEFAULT     r   ALTER TABLE ONLY public."animeTypes" ALTER COLUMN id SET DEFAULT nextval('public."animeTypes_id_seq"'::regclass);
 >   ALTER TABLE public."animeTypes" ALTER COLUMN id DROP DEFAULT;
       public               postgres    false    222    221    222            1           2604    24714 	   genres id    DEFAULT     f   ALTER TABLE ONLY public.genres ALTER COLUMN id SET DEFAULT nextval('public.genres_id_seq'::regclass);
 8   ALTER TABLE public.genres ALTER COLUMN id DROP DEFAULT;
       public               postgres    false    219    220    220            0           2604    24702    users id    DEFAULT     d   ALTER TABLE ONLY public.users ALTER COLUMN id SET DEFAULT nextval('public.users_id_seq'::regclass);
 7   ALTER TABLE public.users ALTER COLUMN id DROP DEFAULT;
       public               postgres    false    218    217            �          0    24729    animeTitles 
   TABLE DATA           �   COPY public."animeTitles" (id, "idOfType", "idOfGenre", "idModerator", "originalName", "titleName", "yearOfRelease", description, poster, "countofSeries", duration, "isComplete", studio) FROM stdin;
    public               postgres    false    224   f'       �          0    24720 
   animeTypes 
   TABLE DATA           9   COPY public."animeTypes" (id, "typeOfAnime") FROM stdin;
    public               postgres    false    222   �(       �          0    24711    genres 
   TABLE DATA           1   COPY public.genres (id, "genreName") FROM stdin;
    public               postgres    false    220   )       �          0    24698    users 
   TABLE DATA           R   COPY public.users (id, "firstName", "lastNamr", "dateOfRegistration") FROM stdin;
    public               postgres    false    217   k)       �           0    0    animeTitles_id_seq    SEQUENCE SET     B   SELECT pg_catalog.setval('public."animeTitles_id_seq"', 2, true);
          public               postgres    false    223            �           0    0    animeTypes_id_seq    SEQUENCE SET     B   SELECT pg_catalog.setval('public."animeTypes_id_seq"', 1, false);
          public               postgres    false    221            �           0    0    genres_id_seq    SEQUENCE SET     ;   SELECT pg_catalog.setval('public.genres_id_seq', 1, true);
          public               postgres    false    219            �           0    0    users_id_seq    SEQUENCE SET     :   SELECT pg_catalog.setval('public.users_id_seq', 1, true);
          public               postgres    false    218            ;           2606    24736    animeTitles animeTitles_pkey 
   CONSTRAINT     ^   ALTER TABLE ONLY public."animeTitles"
    ADD CONSTRAINT "animeTitles_pkey" PRIMARY KEY (id);
 J   ALTER TABLE ONLY public."animeTitles" DROP CONSTRAINT "animeTitles_pkey";
       public                 postgres    false    224            9           2606    24727    animeTypes animeTypes_pkey 
   CONSTRAINT     \   ALTER TABLE ONLY public."animeTypes"
    ADD CONSTRAINT "animeTypes_pkey" PRIMARY KEY (id);
 H   ALTER TABLE ONLY public."animeTypes" DROP CONSTRAINT "animeTypes_pkey";
       public                 postgres    false    222            7           2606    24718    genres genres_pkey 
   CONSTRAINT     P   ALTER TABLE ONLY public.genres
    ADD CONSTRAINT genres_pkey PRIMARY KEY (id);
 <   ALTER TABLE ONLY public.genres DROP CONSTRAINT genres_pkey;
       public                 postgres    false    220            5           2606    24709    users users_pkey 
   CONSTRAINT     N   ALTER TABLE ONLY public.users
    ADD CONSTRAINT users_pkey PRIMARY KEY (id);
 :   ALTER TABLE ONLY public.users DROP CONSTRAINT users_pkey;
       public                 postgres    false    217            <           2606    24742    animeTitles fk_titles_genres    FK CONSTRAINT     �   ALTER TABLE ONLY public."animeTitles"
    ADD CONSTRAINT fk_titles_genres FOREIGN KEY ("idOfGenre") REFERENCES public.genres(id) NOT VALID;
 H   ALTER TABLE ONLY public."animeTitles" DROP CONSTRAINT fk_titles_genres;
       public               postgres    false    4663    220    224            =           2606    24737    animeTitles fk_titles_types    FK CONSTRAINT     �   ALTER TABLE ONLY public."animeTitles"
    ADD CONSTRAINT fk_titles_types FOREIGN KEY ("idOfType") REFERENCES public."animeTypes"(id) NOT VALID;
 G   ALTER TABLE ONLY public."animeTitles" DROP CONSTRAINT fk_titles_types;
       public               postgres    false    222    224    4665            >           2606    24747    animeTitles fk_titles_users    FK CONSTRAINT     �   ALTER TABLE ONLY public."animeTitles"
    ADD CONSTRAINT fk_titles_users FOREIGN KEY ("idModerator") REFERENCES public.users(id) NOT VALID;
 G   ALTER TABLE ONLY public."animeTitles" DROP CONSTRAINT fk_titles_users;
       public               postgres    false    224    4661    217            �     x����J�@���S�H�IN-m����k���r�aoO�;��Z�h B���
�7rriRX��6;�~�o%�$&ڈ1�*���mh-�j����A��&���G��{�8�j�N� !�\�U:s� �Кam�)[�>��n���J����V�+U�K����V���f:���	׆���ܮl�]�����=|.�1V������ß��U�� �pj��8��:q�Њ[�3�Oz�7zb�����t��]f���J��fo��y��'�      �   f   x����0c_T��W ���b�D= :��� ��^G�3���uI� �v�x�7e?��℁�\骤Ba��G֋�%08���x���OMLDa�7_      �   T   x���	�0@�a۸�i-l��k!����m��|�R�̙#j%�<\��Z+'�z��\=�����
��@�r׮P���2r      �   �   x�]�M
�0���.����w�0��
�N�ٻ��(��on�KA(B����M�`����S���?R8��ni}e
�	���y.Z����3�����E�������@ڣ�,��e*���Jp�h�RN���R~7���1���k     